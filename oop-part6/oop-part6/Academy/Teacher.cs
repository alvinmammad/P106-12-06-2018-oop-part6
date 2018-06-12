using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_part6.Academy
{
    class Teacher:Academy
    {
        public override void HelpToStudent()
        {

        }
        public virtual void Teach(string _lessonName)
        {
            Console.WriteLine("Please teach {0} yoxsa ayin sonunda pesman olarsan",_lessonName);
        }
    }
}
