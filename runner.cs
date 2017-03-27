using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeOSReplay
{
    internal class runner
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        int _start;

        public int Start
        {
            get { return _start; }
            set { _start = value; }
        }
        int _finish;

        public int Finish
        {
            get { return _finish; }
            set { _finish = value; }
        }
        int _status;

        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }
        int _cardNo;

        public int CardNo
        {
            get { return _cardNo; }
            set { _cardNo = value; }
        }
        int _startNo;

        public int StartNo
        {
            get { return _startNo; }
            set { _startNo = value; }
        }
        int _classe;

        public int Classe
        {
            get { return _classe; }
            set { _classe = value; }
        }
        Card _card;

        internal Card Card
        {
            get { return _card; }
            set { _card = value; }
        }

        internal runner(int id, string name, /*int start, int finish, */int status, int cardNo, int startNo, int classe, string punchesstr, int cardReadId, int cardId, List<int> _postes)
        {
            _id = id;
            _name = name;
            _status = status;
            _cardNo = cardNo;
            _startNo = startNo;
            _classe = classe;
            _card = new Card(cardNo, punchesstr, cardReadId, cardId, _postes);
            _start = _card.Punches.getStart();
            _finish = _card.Punches.getFinish();
        }
    }
}
