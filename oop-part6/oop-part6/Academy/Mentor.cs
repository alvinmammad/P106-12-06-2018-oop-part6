using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_part6.Academy
{
    class Mentor:Academy,IMentor
    {
        private readonly int id=8;
       
        public  void HelpToStudent()
        {
            var a = id;
            
        }

        public void AttendToLab()
        {

        }

        public  override void TerbiyeliOl()
        {
           
        }

        public override void GedIsinleMesqulOl(string _isinAdi) {
            Console.WriteLine(_isinAdi);
        }

        public Mentor()
        {
            id = 5;
        }
    }
}
