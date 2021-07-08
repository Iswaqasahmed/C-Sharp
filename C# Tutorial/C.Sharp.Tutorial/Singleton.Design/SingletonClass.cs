using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Sharp.Tutorial.Singleton.Design
{
    class SingletonClass
    {
        public static SingletonClass singletonInstance; // why class reference variable  to 
        /// <summary>
        /// no one will create its instance
        /// </summary>
        private SingletonClass()
        {

        }

        /// <summary>
        /// To control only one instance of class 
        /// </summary>
        /// <returns>class instanfea</returns>
        public static SingletonClass GetInstance()
        {
            if (singletonInstance == null)
            {
                singletonInstance = new SingletonClass();
            }

            return singletonInstance;
        }




    }
}
