using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeOSReplay
{
    internal class Card
    {
        int _cardNo;

        public int CardNo
        {
            get { return _cardNo; }
            set { _cardNo = value; }
        }
        Punches _punches;

        internal Punches Punches
        {
            get { return _punches; }
            //set { _punches = value; }
        }
        int _readId;

        public int ReadId
        {
            get { return _readId; }
            set { _readId = value; }
        }
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        internal Card(int cardNo, string punchesstr, int readId, int id, List<int> _postes)
        {
            _cardNo = cardNo;
            _punches = new Punches(punchesstr, _postes);
            _readId = readId;
            _id = id;
        }
    }
}
