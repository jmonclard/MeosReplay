using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeOSReplay
{
    internal class Punches
    {
        bool _finished = false;

        public bool Finished
        {
            get { return _finished; }
            set { _finished = value; }
        }
        List<int[]> _punches = new List<int[]>();

        internal List<int[]> PunchesInfo
        {
            get { return _punches; }
            //set { _punches = value; }
        }

        char[] sepes = { ';' };
        char[] sepm = { '-' };
        internal Punches(string punches, List<int> _postes)
        {
            _finished = false;
            string[] ss = punches.Split(sepes);
            foreach (string s in ss)
            {
                try
                {
                    string sred = s.Trim();
                    if (!string.IsNullOrEmpty(sred))
                    {
                        string[] ssm = sred.Split(sepm);
                        if (ssm.Length == 2)
                        {
                            try
                            {
                                int poste = int.Parse(ssm[0]);
                                int temps = int.Parse(ssm[1]);
                                if (_postes.IndexOf(poste) < 0)
                                {
                                    // n'existe pas encore
                                    _postes.Add(poste);
                                }
                                _punches.Add(new int[] { poste, temps, 0 });// 0 pour dire que pas encore utilisé
                            }
                            catch (Exception ex)
                            {
                                string exc = ex.Message;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    string exc = ex.Message;
                }
            }
        }
        internal void reset()
        {
            _finished = false;
            int ic = _punches.Count;
            for(int i=0;i<ic;i++)
            {
                _punches[i][2] = 0;
            }
        }
        internal List<int[]> tick(int tickTime)
        {
            if (tickTime > getFinish())
            {
                if (_finished)
                {
                    return new List<int[]>();
                }
                else
                {
                    _finished = true;
                    return null;
                }
            }
            List<int[]> _punchesOk = new List<int[]>();
            int ic = _punches.Count;
            for (int i = 0; i < ic; i++)
            {
                if ((_punches[i][1] < tickTime) && (_punches[i][2] == 0))
                {
                    _punches[i][2] = 1;// utilisé
                    _punchesOk.Add(_punches[i]);
                }
            }

            return _punchesOk;
        }

        internal int getStart()
        {
            if (_punches.Count > 0)
            {
                return _punches[0][1];
            }
            else
                return 0;
        }

        internal int getFinish()
        {
            if (_punches.Count > 0)
            {
                return _punches[_punches.Count-1][1];
            }
            else
                return 0;
        }
    }
}
