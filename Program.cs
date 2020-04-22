using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Herança_e_Polimorfismo.Entities;
using System.Globalization;
namespace Herança_e_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int number = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value pr hour : ");
                double Vhour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if (ch == 'y' || ch == 'Y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, Vhour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, Vhour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");

            foreach(Employee emp in list)
            {
                Console.WriteLine(emp.Name+" - $ "+emp.Payment().ToString("F2",CultureInfo.InvariantCulture));
            }

        }
    }
}
