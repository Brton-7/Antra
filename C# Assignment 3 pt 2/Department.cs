using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Classes
{
    interface IDepartmentService
    {
        void Budget();
        void printCourses();
    }
    public class Department
    {
        public string DeptName { get; set; }
        public string deptHead { get; set; }
        private double budget = 10000;
        public Instructor HeadInstructor { get; set; }

        public List<Course> CourseList { get; set; }

        public void Budget(DateTime StartTime, DateTime EndTime)
        {
            int year = EndTime.Year - StartTime.Year;
            budget *= year;
            Console.WriteLine("New Budget for the year is: " + budget);
        }
        public void printCourses() 
        {
            for(int i =0; i< CourseList.Count; i++)
            {
                Console.WriteLine(CourseList[i]);
            }
        }
    }
}
