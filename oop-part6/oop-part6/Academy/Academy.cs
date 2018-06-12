using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_part6.Academy
{
    interface IMentor {
        void AttendToLab();
        void HelpToStudent();
    }
    interface ITeacher
    {
        void CheckHomework();
        void Teach();
    }

    abstract class Academy
    {
        public abstract void TerbiyeliOl();
        public abstract void GedIsinleMesqulOl(string _isinAdi);
    }
}
