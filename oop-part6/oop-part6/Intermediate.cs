using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_part6
{
    class Intermediate:Base
    {
        public dynamic SomeFeature=4;
        public Intermediate()
            : base()
        {
            Console.WriteLine("sadsacscwec");
         
        }
        public Intermediate(int _id)
            : base(_id)
        {

        }

        public  void DoSome()
        {
            Console.WriteLine("Base method without parametr");
          
            var b=5;
        }

        public int DoSome(int _id)
        {
            return _id;
        }

        public int SomeMethod()
        {
            return 5;
        }

        public int SomeMethod(int _id)
        {
            return _id;
        }

        public  void Some()
        {

        }

       
    }
}
