using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Classes
{
    interface IInstructorService : IPersonService
    {
        double CalculateSalary();
    }
    public class Instructor : Person
    {
        public double bonus = 0.10;
        private double salary;
        private DateTime JoinDate { get; set; }

        public override double CalculateSalary(double currSalary)
        {
            double temp = (currSalary * bonus) * (DateTime.Now.Year - JoinDate.Year);
            salary += temp;
            return salary;
        }
    }
}
