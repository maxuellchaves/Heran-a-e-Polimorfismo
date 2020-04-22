using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança_e_Polimorfismo.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePeHour { get; set; }


        public Employee()
        {

        }

        public Employee(string name, int hours, double valuePeHour)
        {
            Name = name;
            Hours = hours;
            ValuePeHour = valuePeHour;
        }

        public virtual double Payment()
        {
            return Hours * ValuePeHour;
        }


    }
}
