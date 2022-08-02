using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Anniversery
    {
        public void ageAndAnniversery()
        {
            Console.WriteLine("\n===========================Age and Anniversery===============================\n");
            int daysToYears = 365;
            DateTime dob = Convert.ToDateTime("1996/10/2");
            int age = DateTime.Now.Year - dob.Year;
            int daysToNextAnniversery = 10000 - ((age * daysToYears) % 10000);

            Console.WriteLine("You are " + age*daysToYears + "(" + age + " years)" + "days old");
            Console.WriteLine("There are " + daysToNextAnniversery + " days until your next anniversery");
        }
    }
}
