using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace modulo14.Aula7.Entities
{
    class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmplyee)
        {
            string[] array = csvEmplyee.Split(",");
            Name = array[0];
            Salary = double.Parse(array[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Employee))
            {
                throw new ArgumentException("Camparing error: argument isn't a Employee");
            }
            Employee outro = obj as Employee;

            return Salary.CompareTo(outro.Salary);
        }
    }
}
