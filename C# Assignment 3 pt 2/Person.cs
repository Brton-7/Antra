using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Classes
{
    interface IPersonService
    {        
        int CalculateAge();
        double CalculateSalary();
    }
    public abstract class Person
    {
        private string name { get; set; }
        private string address { get; set; }
        private int age { get; set; }
        private double salary { get; set; }

        public virtual int CalculateAge(DateTime DateOfBirth)
        {
            age = DateTime.Now.Year - DateOfBirth.Year;
            return age;
        }
        public virtual double CalculateSalary(double num)
        {
            salary = 40000.00;
            return salary;
        }
    }
}
