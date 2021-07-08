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
}
