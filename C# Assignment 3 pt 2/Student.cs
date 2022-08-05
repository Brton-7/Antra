using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Classes
{
    interface IStudentService : IPersonService
    {
        public void addCourse();
        public void removeCourse();
        public double CalculateGPA();
    }
    public class Student : Person
    {
        private double gpa { get; set; }
        List<Course> studentsCourses { get; set; }
        public void addCourse(Course course)
        {
            studentsCourses.Add(course);
        }
        public void removeCourse(Course course)
        {
            studentsCourses.Remove(course);
        }
        public double CalculateGPA(Course course)
        {
            double num = 0;
            int count = 0;
            switch (course.Grade)
            {
                case 'A':
                    num += 4.0;
                    count++;
                    break;
                case 'B':
                    num += 3.0;
                    count++;
                    break;
                case 'C':
                    num += 2.0;
                    count++;
                    break;
                case 'D':
                    num += 1.0;
                    count++;
                    break;
                case 'F':
                    count++;
                    break;
            }
            gpa = num/count;
            return gpa;
        }
    }
}
