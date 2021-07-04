using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace C.Sharp.Tutorial.socket
{
    class Server
    {
        public void Recieved()
        {
            Socket sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sck.Bind(new IPEndPoint(IPAddress.Any , 1994));
            sck.Listen(0);
            Socket acc = sck.Accept();
            byte[] buffer = Encoding.Default.GetBytes("Message");
            acc.Send(buffer, 0, buffer.Length, 0);
            buffer = new byte[255];
            int rec = acc.Receive(buffer, 0, buffer.Length, 0);
            Array.Resize(ref buffer, rec);
            Console.WriteLine(Encoding.Default.GetString(buffer));
            sck.Close();
            acc.Close();
            sck.Dispose();
            acc.Dispose();

        }
    }
}
