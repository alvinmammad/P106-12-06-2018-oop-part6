using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_part6
{
    class Derived:Intermediate
    {
        public string SomeFeature = "Something";
        public Derived()
            : base()
        {
            Console.WriteLine(base.SomeFeature);
           
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

        public void Some()
        {
            Console.WriteLine("hello");
        }


    }
}
