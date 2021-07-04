using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C.Sharp.Tutorial.Encapsulation;
using C.Sharp.Tutorial.socket;

namespace C.Sharp.Tutorial
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Encapsulation.Encapsulation ec = new Encapsulation.Encapsulation();

            //ocket.Client sck = new socket.Client();
            //sck.client();
            socket.Server sck = new socket.Server();
            sck.Recieved();
            Console.ReadKey();
        }
    }
}
