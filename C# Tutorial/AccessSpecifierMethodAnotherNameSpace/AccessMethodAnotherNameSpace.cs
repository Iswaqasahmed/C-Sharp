using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AccessSpecifierMethodAnotherNameSpace
{
    class AccessMethodAnotherNameSpace: C.Sharp.Tutorial.AccessSpecifiers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main of Access Method Another NameSpace \n");
            Console.WriteLine("Only Protected, Protected Internal and public method are accessbile to outside the project with project in" +
                "inheritance from class (Namespace.Class) ");
            AccessMethodAnotherNameSpace ac = new AccessMethodAnotherNameSpace();
            ac.ProtectedMethod();
            ac.ProtectedInternalMethod();
            ac.PublicMethod();
            Console.ReadKey();

        }
    }


    class AccessMethodAnotherNameSpaceInheritance
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main of Access Method Another NameSpace Inheritance Class ");
            AccessMethodAnotherNameSpace aman = new AccessMethodAnotherNameSpace();
            aman.PublicMethod();
            Console.ReadKey();
        }
    }

}
