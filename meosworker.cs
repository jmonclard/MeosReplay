using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;

namespace MeOSReplay
{
    internal class meosworker
    {
        string dbg = "";
        List<int> _postes = new List<int>();

        public List<int> Postes
        {
            get { return _postes; }
            set { _postes = value; }
        }
        List<runner> _runners = new List<runner>();

        internal List<runner> Runners
        {
            get { return _runners; }
            set { _runners = value; }
        }
        string _filename;

        public string Filename
        {
            get { return _filename; }
            set { _filename = value; }
        }
        DateTime _date;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        int _zeroTime;

        public int ZeroTime
        {
            get { return _zeroTime; }
            set { _zeroTime = value; }
        }
        int _firstStart = int.MaxValue;

        public int FirstStart
        {
            get { return _firstStart; }
            set { _firstStart = value; }
        }
        int _lastFinish = int.MinValue;

        public int LastFinish
        {
            get { return _lastFinish; }
            set { _lastFinish = value; }
        }
        internal meosworker()
        {
        }
        internal void init(string filename)
        {
            string xmlContent = string.Empty;
            _filename = filename;
            xmlContent = File.ReadAllText(filename);

            using (XmlReader reader = XmlReader.Create(new StringReader(xmlContent)))
            {
                reader.ReadToFollowing("Date");
                _date = reader.ReadElementContentAsDateTime();
                reader.ReadToFollowing("ZeroTime");
                _zeroTime = reader.ReadElementContentAsInt();

                int id;
                string name;
                //int start;
                //int finish;
                int status;
                int cardNo;
                int startNo;
                int classe;
                string punchesstr;
                int cardReadId;
                int cardId;

                while (reader.ReadToFollowing("Runner"))
                {
                    try
                    {
                        reader.ReadToFollowing("Id"); id = reader.ReadElementContentAsInt();
                        reader.ReadToFollowing("Name"); name = reader.ReadElementContentAsString();
                        //reader.ReadToFollowing("Start"); start = reader.ReadElementContentAsInt();
                        //reader.ReadToFollowing("Finish"); finish = reader.ReadElementContentAsInt();
                        reader.ReadToFollowing("Status"); status = reader.ReadElementContentAsInt();
                        reader.ReadToFollowing("CardNo"); cardNo = reader.ReadElementContentAsInt();
                        reader.ReadToFollowing("StartNo"); startNo = reader.ReadElementContentAsInt();
                        reader.ReadToFollowing("Class"); classe = reader.ReadElementContentAsInt();
                        reader.ReadToFollowing("Punches"); punchesstr = reader.ReadElementContentAsString();
                        reader.ReadToFollowing("ReadId"); cardReadId = reader.ReadElementContentAsInt();
                        reader.ReadToFollowing("Id"); cardId = reader.ReadElementContentAsInt();

                        runner r = new runner(id, name, /*start, finish, */status, cardNo, startNo, classe, punchesstr, cardReadId, cardId, _postes);
                        if (r.Start < _firstStart)
                        {
                            _firstStart = r.Start;
                        }
                        if (r.Finish > _lastFinish)
                        {
                            _lastFinish = r.Finish;
                        }
                        _runners.Add(r);
                    }
                    catch (Exception ex)
                    {
                        dbg = ex.Message;
                    }
                }
            }
            _postes.Sort();
        }
        internal List<object[]> tick(int tickTime)
        {
            List<object[]> lo = new List<object[]>();
            // cherchons tous les trucs dont la date est < dt
            foreach (runner r in _runners)
            {
                List<int[]> punchesOk = r.Card.Punches.tick(tickTime);
                if (punchesOk == null)
                {
                    // c'est que fini
                    lo.Add(new object[] { r });
                }
                else
                {
                    if (punchesOk.Count > 0)
                    {
                        lo.Add(new object[] { r, punchesOk });
                    }
                    else
                    {
                        // déjà fini ou rien a dire
                    }
                }
            }
            return lo;
        }
    }
}