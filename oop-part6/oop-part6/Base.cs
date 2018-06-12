using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_part6
{
    class Base:Main
    {
        public int Id { get; set; }
        protected string Name { get; set; }

        public Base()
        {
           
        }
        public Base(int _id)
        {
            Id = _id;
        }
        public Base(int _id, string _name)
        {
            Id = _id;
            Name = _name;
            Console.WriteLine(Id+" "+Name);
        }

       
    }
}
