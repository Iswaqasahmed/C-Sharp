using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Sharp.Tutorial.Complex.Class
{
    class ComplexClass
    {
        internal float? real = null, image = null;
        public ComplexClass()
        {
        }

        public ComplexClass(float r,float i)
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
        public ComplexClass AddComplex(ComplexClass y)
        {
            ComplexClass t;
            t = new ComplexClass();
            t.real = real + y.real;
            t.image = image + y.image;
            return t; // what would be t return ?
        }



    }
}
