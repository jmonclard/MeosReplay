using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Net.Sockets;

namespace MeOSReplay
{
    internal class Sender
    {
        IPAddress _ipaddress;
        Socket tempSocket;

        public IPAddress Ipaddress
        {
            get { return _ipaddress; }
            set { _ipaddress = value; }
        }
        int _port;

        public int Port
        {
            get { return _port; }
            set { _port = value; }
        }
        internal Sender(IPAddress ip, int port)
        {
            _ipaddress = ip;
            _port = port;

            IPEndPoint ipe = new IPEndPoint(_ipaddress, _port);
            tempSocket = new Socket(ipe.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            tempSocket.Connect(ipe);
        }

        internal bool sendPunch(int codeNumber, int cardNumber, int codeTime)
        {
            var ms = new MemoryStream(15);
            var bw = new BinaryWriter(ms);
            bw.Write((byte)0);// type 0=> punch
            bw.Write((short)codeNumber);
            bw.Write((int)cardNumber);
            bw.Write((int)0);//codeday obsolete
            bw.Write((int)codeTime);

            byte[] barray = ms.ToArray();

            bool b = tempSocket.Connected;
            if (b)
            {
                tempSocket.Send(barray, barray.Length, 0);
            }
            return b;
        }

        internal bool sendCard(int cardNumber, Punches punches, int zeroTime)
        {
            var ms = new MemoryStream();
            var bw = new BinaryWriter(ms);
            bw.Write((byte)64);// type 0=> cardnumber
            bw.Write((short)punches.PunchesInfo.Count);// la taille
            bw.Write((int)cardNumber);
            bw.Write((int)0);//codeday obsolete
            bw.Write((int)0);

            foreach (int[] p in punches.PunchesInfo)
            {
                int codeNumber = (int)p[0];
                int codeTime = (int)(p[1] + zeroTime)*10;
                bw.Write((int)codeNumber);
                bw.Write((int)codeTime);
            }

            byte[] barray = ms.ToArray();

            bool b = tempSocket.Connected;
            if (b)
            {
                tempSocket.Send(barray, barray.Length, 0);
            }
            return b;
        }
    }
}
