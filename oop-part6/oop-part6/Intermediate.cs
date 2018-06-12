using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_part6
{
    class Intermediate:Base
    {
        public Intermediate()
            : base()
        {
         
        }
        public Intermediate(int _id)
            : base(_id)
        {

        }

        public  void DoSome()
        {
            Console.WriteLine("Base method without parametr");
        }

        public void DoSome(int _id)
        {
            Console.WriteLine("Base method");
        }
    }
}
