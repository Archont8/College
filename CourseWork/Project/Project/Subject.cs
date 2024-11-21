using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Subject
    {
        string name; // Название предмета
        int hours; // Рабочие часы по предмету в неделю
        public string Name { get => name; set => name = value; }
        public int Hours { get => hours; set => hours = value; }
        public Subject(string name, int hours)
        {
            this.name = name;
            this.hours = hours;
        }
    }
}
