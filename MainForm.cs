using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Collections.Concurrent;
using System.Threading;

namespace MeOSReplay
{
    public partial class MainForm : Form
    {
        ConcurrentQueue<object[]> _actionToDo = new ConcurrentQueue<object[]>();
        enum interfaceMode { eInit, eConfiguration, eRunning };
        enum actionType { ePunch, eCard };
        meosworker _worker;
        double[] speedFactor = { 50.0, 100.0, 150.0, 200.0, 250.0, 500.0, 1000.0 };
        double speedFactorIncr = 50.0;// pour un timer à 50ms
        List<int> _checkedRadio = new List<int>();
        DateTime currentTime;
        DateTime startTime;
        DateTime stopTime;
        int radioTransmitTime_base;
        int radioTransmitTime_random;
        int finishToReadOut_base;
        int finishToReadOut_random;
        Random _rand = new Random();
        bool jumpNext = false;

        Sender _sender = null;
        bool timeIsOk;

        public MainForm()
        {
            InitializeComponent();

            updateRadioStatus();
            updateRandoms();

            speedFactorTrackBar.Minimum = 1;
            speedFactorTrackBar.Maximum = speedFactor.Count();

            _worker = new meosworker();
            updateInterface(interfaceMode.eInit);
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            switch (xmlOpenFileDialog.ShowDialog())
            {
                case System.Windows.Forms.DialogResult.OK:
                    try
                    {
                        _worker.init(xmlOpenFileDialog.FileName);
                        logTextBox.Text = string.Empty;
                        logTextBox.AppendText("Runners:" + _worker.Runners.Count.ToString() + Environment.NewLine);
                        logTextBox.AppendText("Steps:" + _worker.Postes.Count.ToString() + Environment.NewLine);
                        
                        _checkedRadio = new List<int>();
                        updateRadioStatus();

                        radioCheckedListBox.Items.Clear();
                        foreach (int poste in _worker.Postes)
                        {
                            radioCheckedListBox.Items.Add(poste.ToString());
                        }
                        
                        xmlTextBox.Text = xmlOpenFileDialog.FileName;
                        startTextBox.Text = _worker.Date.AddSeconds((double)(_worker.ZeroTime +  _worker.FirstStart)).AddSeconds(-10).ToLongTimeString();
                        stopTextBox.Text = _worker.Date.AddSeconds((double)(_worker.ZeroTime + _worker.LastFinish)).AddMinutes(30).ToLongTimeString();
                        currentTextBox.Text = startTextBox.Text;
                        updateInterface(interfaceMode.eConfiguration);
                        timeIsOk = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;
            }
        }

        private void updateInterface(interfaceMode im)
        {
            switch (im)
            {
                case interfaceMode.eInit:
                    fileGroupBox.Enabled = true;
                    settingsGroupBox.Enabled = false;
                    commandsGroupBox.Enabled = false;
                    radioListGroupBox.Enabled = false;
                    break;
                case interfaceMode.eConfiguration:
                    fileGroupBox.Enabled = false;
                    settingsGroupBox.Enabled = true;
                    commandsGroupBox.Enabled = true;
                    radioListGroupBox.Enabled = true;
                    break;
                case interfaceMode.eRunning:
                    fileGroupBox.Enabled = false;
                    settingsGroupBox.Enabled = false;
                    commandsGroupBox.Enabled = true;
                    radioListGroupBox.Enabled = false;
                    break;
            }
        }

        private void speedFactorTrackBar_Scroll(object sender, EventArgs e)
        {
            int index = speedFactorTrackBar.Value;
            speedFactorIncr = speedFactor[index-1];
            speedFactorLabel.Text = "(* " + Math.Truncate(0.5 + speedFactorIncr / mainTimer.Interval).ToString() + ")";
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (!timeIsOk)
            {
                if (!senderBackgroundWorker.IsBusy)
                {
                    senderBackgroundWorker.RunWorkerAsync();
                }
                if (_sender == null)
                {
                    try
                    {
                        _sender = new Sender(IPAddress.Parse(ipTextBox.Text), int.Parse(portTextBox.Text));
                    }
                    catch (Exception ex)
                    {
                        _sender = null;
                        logTextBox.AppendText(ex.Message + Environment.NewLine);
                    }
                }
                foreach (runner r in _worker.Runners)
                {
                    r.Card.Punches.reset();// pas beau !
                }
                startTime = DateTime.Parse(startTextBox.Text);
                stopTime = DateTime.Parse(stopTextBox.Text);
                currentTime = startTime;
                currentTextBox.Text = currentTime.ToLongTimeString();

                timeIsOk = true;
                pauseButton.Enabled = true;
                stopButton.Enabled = true;

                speedFactorTrackBar_Scroll(null, null);
            }
            jumpNext = false;
            logTextBox.AppendText("--------------------" + Environment.NewLine);
            logFullTextBox.AppendText("--------------------" + Environment.NewLine);

            mainTimer.Enabled = true;
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            bool done = false;
            bool isjumpNext = jumpNext;

            while (!done)
            {
                currentTime = currentTime.AddMilliseconds(speedFactorIncr);// = new DateTime(DateTime.Now.Subtract(refTime).Add(new TimeSpan(startTime.Ticks)).Ticks);
                currentTextBox.Text = currentTime.ToLongTimeString();

                int nowsec = (int)(new TimeSpan(currentTime.Hour, currentTime.Minute, currentTime.Second).TotalSeconds);

                int tickTime = nowsec - _worker.ZeroTime;

                List<object[]> lo = _worker.tick(tickTime);
                if (lo.Count > 0)
                {
                    foreach (object[] oo in lo)
                    {
                        runner r = oo[0] as runner;
                        //oo[0] runner
                        //oo[1] punchesok (si plusieurs)
                        // ou
                        //oo[0] runner   a fini
                        if (oo.Length == 2)
                        {
                            List<int[]> pok = oo[1] as List<int[]>;
                            foreach (int[] p in pok)
                            {
                                // cherchons si ce poste est checké !
                                string info = currentTime.ToLongTimeString() + "\t" + p[0].ToString() + "\t" + r.Name;
                                logFullTextBox.AppendText(info);
                                int index = _checkedRadio.IndexOf(p[0]);
                                if (index >= 0)
                                {
                                    done = true;

                                    int timeCode = (p[1] + _worker.ZeroTime) * 10;
                                    _actionToDo.Enqueue(new object[] { actionType.ePunch, p[0], r.CardNo, timeCode, info + "\t* RADIO *" + Environment.NewLine });
                                    logFullTextBox.AppendText("\t* RADIO *");

                                    //_sender.sendPunch(p[0], r.CardNo, timeCode);
                                    //logTextBox.AppendText(currentTime.ToLongTimeString() + "\t" + p[0].ToString() + "\t" + r.Name + "\t* RADIO *" + Environment.NewLine);
                                }
                                logFullTextBox.AppendText(Environment.NewLine);
                            }
                        }
                        else
                            if (oo.Length == 1)
                            {
                                done = true;
                                //_sender.sendCard(r.CardNo, r.Card.Punches, _worker.ZeroTime);
                                string info = currentTime.ToLongTimeString() + "\t" + r.Name + "\t* FINISH **********" + Environment.NewLine;
                                logFullTextBox.AppendText(info);
                                _actionToDo.Enqueue(new object[] { actionType.eCard, r.CardNo, r.Card.Punches, _worker.ZeroTime, info });
                                //logTextBox.AppendText(currentTime.ToLongTimeString() + "\t" + r.Name + "\t* FINISH *" + Environment.NewLine);
                            }
                    }
                }

                if (currentTime.CompareTo(stopTime) > 0)
                {
                    done = true;
                    stopButton_Click(null, null);
                }
                if (!isjumpNext)
                {
                    done = true;// on attendra la suite
                }
                if (!isjumpNext)
                {
                    Application.DoEvents();
                }
            }
            if (isjumpNext)
            {
                jumpNext = false;
            }
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            mainTimer.Enabled = false;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            mainTimer.Enabled = false;
            timeIsOk = false;
        }

        private void radioCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int val = int.Parse(radioCheckedListBox.Text);
            // voyons la liste
            if (e.NewValue == CheckState.Checked)
            {
                if (_checkedRadio.IndexOf(val) >= 0)
                {
                    // !!!!!
                }
                else
                {
                    _checkedRadio.Add(val);
                    logTextBox.AppendText("Poste " + val.ToString() + " appended to radio list" + Environment.NewLine);
                }
            }
            if (e.NewValue == CheckState.Unchecked)
            {
                _checkedRadio.Remove(val);
                logTextBox.AppendText("Poste " + val.ToString() + " removed from radio list" + Environment.NewLine);
            }
            updateRadioStatus();
        }

        private void updateRadioStatus()
        {
            radioListGroupBox.Text = "Check points (" + _checkedRadio.Count.ToString() + " radio)";
        }

        private void senderBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!senderBackgroundWorker.CancellationPending)
            {
                object[] oo;
                if (_actionToDo.TryDequeue(out oo))
                {
                    try
                    {
                        // just do it
                        actionType _action = (actionType)oo[0];
                        switch (_action)
                        {
                            case actionType.eCard:
                                {
                                    // récupération des paramètres
                                    int cardno = (int)oo[1];
                                    Punches p = oo[2] as Punches;
                                    int zt = (int)oo[3];
                                    string info = oo[4] as string;

                                    // petite attente
                                    Thread.Sleep(1000 * finishToReadOut_base + _rand.Next(1000 * finishToReadOut_random));

                                    // et envoi des données
                                    if (_sender != null)
                                    {
                                        _sender.sendCard(cardno, p, zt);
                                    }

                                    // notification qu'il y a eu une action
                                    senderBackgroundWorker.ReportProgress(0, info);
                                }
                                break;
                            case actionType.ePunch:
                                {
                                    // récupération des paramètres
                                    int poste = (int)oo[1];
                                    int cardno = (int)oo[2];
                                    int timeCode = (int)oo[3];
                                    string info = oo[4] as string;

                                    // petite attente
                                    Thread.Sleep(1000 * radioTransmitTime_base + _rand.Next(1000 * radioTransmitTime_random));

                                    // et envoi des données
                                    if (_sender != null)
                                    {
                                        _sender.sendPunch(poste, cardno, timeCode);
                                    }

                                    // notification qu'il y a eu une action
                                    senderBackgroundWorker.ReportProgress(0, info);
                                }
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        senderBackgroundWorker.ReportProgress(0, ex.Message);
                    }
                }
                else
                {
                    Thread.Sleep(500);
                }
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void senderBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string info = e.UserState as string;
            logTextBox.AppendText(info);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            senderBackgroundWorker.CancelAsync();
        }

        private void rttNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            updateRandoms();
        }

        private void rttrandomNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            updateRandoms();
        }

        private void ftrNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            updateRandoms();
        }

        private void ftrrandomNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            updateRandoms();
        }

        private void updateRandoms()
        {
            radioTransmitTime_base = (int)rttNumericUpDown.Value;
            radioTransmitTime_random = (int)rttRandomNumericUpDown.Value;
            finishToReadOut_base = (int)ftrNumericUpDown.Value;
            finishToReadOut_random = (int)ftrRandomNumericUpDown.Value;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            jumpNext = true;
        }
    }
}
