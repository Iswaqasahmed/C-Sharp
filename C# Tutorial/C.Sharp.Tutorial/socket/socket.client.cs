using System;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C.Sharp.Tutorial.socket
{
    class socket
    {
        public void Sender()
        {
            Socket sck = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            Console.WriteLine();
            Console.WriteLine("listening");
            sck.Bind(new IPEndPoint(0,1994));
            sck.Listen(0);
            
            Socket acc = sck.Accept();

            byte[] buffer = Encoding.Default.GetBytes("hell world");
            acc.Send(buffer,0,buffer.Length,0);
            Console.WriteLine("sending");


        }
    }
}
