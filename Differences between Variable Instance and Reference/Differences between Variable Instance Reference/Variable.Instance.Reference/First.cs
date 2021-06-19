using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable.Instance.Reference
{
    class CVariable
    {
        // Class is user define data type: its blue print of data, it doesn't have memory allocation
        // int i ;  memeory null

        // int = 100; it is only plan means its blue print of class
        // int i = 100 , its constuctor of class



        static int var1;
        static int var2;
    }
    class First
    {
        // non static member are access through instance of class
        int x = 100;
        static void Main(string[] args)
        {
            // First cVariable -----> null
            // x = 100  ----------->  cVariable = new First();

            /// Instance of class: a copy that is initialized the new keyword

            First cVariable;  // variable of class
            cVariable = new First();    // cvariable is instance of class
            Console.WriteLine(cVariable.x); // accessing the instance of class 




            /// reference of class: a class variable 
            ///  
            First first = new First(); // first instance of class
            First second = new First(); // second instance of class
            Console.WriteLine(first.x + " " + second.x);

            first.x = 100;
            Console.WriteLine(first.x + " " + second.x);

            second.x = 200;
            Console.WriteLine(first.x + " " + second.x);




        }
    }
}
