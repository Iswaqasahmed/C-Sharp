using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Sharp.Tutorial
{
    public class AccessSpecifiers
    {
        // ------- Access Specifier  ------
        // it's a spicail kind of modifers using which we can define the scope of a type and it's members. of same project
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

        // CASE -I  
        // Consuming the member of class from same class of same project

        //static void Main(string[] args)
        //{
        //    AccessSpecifiers accspecf = new AccessSpecifiers();
        //    accspecf.PrivateMethod();
        //    accspecf.InternalMethod();
        //    accspecf.ProtectedMethod();
        //    accspecf.ProtectedInternalMethod();
        //    accspecf.InternalMethod();
        //}

    }

    public class AccessSpecifierCheck : AccessSpecifiers
    {
        static void Main(string[] args)
        {


            //      with child class we access four method of parent class (if parent class is public) except its private method of same project
            AccessSpecifierCheck accspecf = new AccessSpecifierCheck();
            //accspecf.privatemethod(); // private method can't access out side the scope of that class
            accspecf.InternalMethod();
            accspecf.ProtectedMethod();
            accspecf.ProtectedInternalMethod();
            accspecf.PublicMethod();



            Console.ReadKey();
        }

    }

    class AccessWithoutInstance
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AccessWithoutInstance Main");
            // CASE - II Consuming teh member of class using instance of class of same project

            //            ---- With Base Class we only access three method (wether parent class is public or private ) but with child class we can access four method
            AccessSpecifiers accspecf = new AccessSpecifiers();
            //accspecf.PrivateMethod(); // private method can't access out side the scope of that class
            accspecf.InternalMethod();
            //accspecf.ProtectedMethod();    
            accspecf.ProtectedInternalMethod();
            accspecf.InternalMethod();

        }

    }



}
