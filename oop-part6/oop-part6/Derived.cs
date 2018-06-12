using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_part6
{
    class Derived:Intermediate
    {
        public Derived()
            :base()
        {
           
        }
        public Derived(int _id)
            :base(_id)
        {

        }

        public Derived(int _id,string _message)
        {

        }

        public void DoSome(int _id)    
        {
            Console.WriteLine("Derived method");
        }

        public void DoSome(string _message)
        {
            Console.WriteLine(_message);
        }

    }
}
