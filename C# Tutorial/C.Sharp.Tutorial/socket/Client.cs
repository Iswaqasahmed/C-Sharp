using System;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C.Sharp.Tutorial.socket
{
    class Client
    {
        public void client()
        {
            try
            {

                Socket sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("localhost"), 1994);
                sck.Connect(endPoint);
                Console.WriteLine("Enter Message");
                string msg = Console.ReadLine();
                byte[] msgBuffer = Encoding.Default.GetBytes(msg);
                sck.Send(msgBuffer, 0, msgBuffer.Length, 0);
                byte[] buffer = new byte[255];
                int rec = sck.Receive(buffer, 0, msgBuffer.Length, 0);
                sck.Close();
                sck.Dispose();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }


    }
}
