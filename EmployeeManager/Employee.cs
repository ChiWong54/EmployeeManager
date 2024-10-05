using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager
{
    internal class Employee
    {
        // Properties
        public int listNum { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }
        /*
        public int Hours { get; set; }

        public double HourlyRate = 9.5;
        */

        // Constructor
        public Employee() { }

        public Employee(int a, string firstName, string lastName, string id) 
        {
            listNum = a;
            FirstName = firstName; 
            LastName = lastName;
            Id = id;            
        }

        // Methods
        public string FullName
        {
            get { return FirstName + "" + LastName; }
        }
        /*
        public double WeeklyWage
        {
            get { return Hours * HourlyRate * 7; }
        }
        */
        public override string ToString()
        {
            return $"{listNum}. {FullName}, {Id}";
        }
    }
}
