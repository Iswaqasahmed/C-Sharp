using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Sharp.Tutorial.Complex.Class
{
    class Complex
    {
        internal float? real = null, image = null;
        public Complex()
        {
        }

        public Complex(float r,float i)
        {
            real = r;
            image = i;
        }

        public void GetData()
        {
            float r, i;
            Console.WriteLine("Enter Real and Imaginary Part");
            r = Single.Parse(Console.ReadLine());
            i = Single.Parse(Console.ReadLine());
            real = r;
            image = i;
        }

        public void SetData(float r,float i)
        {
            real = r;
            image = i;
        }

        public void DisplayData()
        {
            Console.WriteLine("Real {0} ",real);
            Console.WriteLine("Imaginary = {0}",image);
        }

        // complex class that is somelogic
        public Complex AddComplex(Complex y)
        {
            Complex t;
            t = new Complex();
            t.real = real + y.real;
            t.image = image + y.image;
            return t; // what would be t return ?
        }
        public Complex MulComplex(Complex y)
        {
            Complex t;
            t = new Complex();
            t.real = real * y.real - image * y.image;
            t.image = real * y.image + y.real * image;
            return t;
        }

    }

    class ComplexNumbers
    {
        public static  string Token()
        {
            string token = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
            byte[] time = BitConverter.GetBytes(DateTime.UtcNow.ToBinary());
            byte[] key = Guid.NewGuid().ToByteArray();
            return token;
        }
        static void Main(string[] args)
        {
            //Complex c1, c2, c3;
            //c1 = new Complex();
            //c1.SetData(2.0f,2.0f);
            //c2 = new Complex();
            //c3 = new Complex();
            ////c3 = c1.AddComplex(c2);
            //c3 = c1.AddComplex(new Complex());
            //Console.WriteLine("Complex C3");
            //c3.DisplayData();
           
            byte[] data = Convert.FromBase64String(Token());
            DateTime when = DateTime.FromBinary(BitConverter.ToInt64(data, 0));
            if (when < DateTime.UtcNow.AddHours(-24))
            {
                Console.WriteLine(" " + data.ToArray());
            }
            Console.WriteLine();
        }
    }


}
