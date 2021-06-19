using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Sharp.Tutorial
{
    class AccessSpecifiers
    {
        // ------- Access Specifier  ------
        // it's a spicail kind of modifers using which we can define the scope of a type and it's members.
        //- private
        //- internal
        //- protected
        //- protected internal
        //-  public       --> Access any where you want



        private void PrivateMethod()
        {
            Console.WriteLine("It is private Method");
        }

        internal void InternalMethod()
        {
            Console.WriteLine("It is internal Method");
        }


        protected void ProtectedMethod()
        {
            Console.WriteLine("It is Protected Method");
        }

        protected internal void ProtectedInternalMethod()
        {
            Console.WriteLine("It is Protected Internal Method");
        }

        public void PublicMethod()
        {
            Console.WriteLine("It is Public Method");
        }
         


    }
}
