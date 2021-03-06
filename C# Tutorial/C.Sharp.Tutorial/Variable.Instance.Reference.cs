using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Sharp.Tutorial
{
    class VariableInstanceReference
    {
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





                First first = new First(); // first instance of class
                First second = new First(); // second instance of class
                Console.WriteLine(first.x + " " + second.x);

                first.x = 100;
                Console.WriteLine(first.x + " " + second.x);

                second.x = 200;
                Console.WriteLine(first.x + " " + second.x);


                /// reference of class: a class variable 
                ///  

                //INSTANCE OF CLASS::: a copy of the that is initialized by using the new keyword which has its own memory and never shared with another instance.

                //REFERENCE OF CLASS::: a copy of the class that is initialized by using an existing instance and references of class will not have any memory of \
                //the instance that assigned for initializing the variable.

                //-- Reference of a class can be called as a pointer to the instance and every modification we perform on the members using instance reflects when
                //we access those members thrugyh reference and vice-versa

                First third = first; // it is pointer to first variable
                Console.WriteLine(first.x + " " + third.x);

                first.x = 400;
                Console.WriteLine(first.x + " " + third.x);

                Console.ReadKey();


            }
        }

    }
}
