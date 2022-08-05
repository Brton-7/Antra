using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Classes
{
    interface ICourseService
    {
        void print();
    }
    public class Course
    {
        public string Name { get; set; }
        public char Grade { get; set; }
        private List<Student> StudentList { get; set; }
        public void print(Student list)
        {
            int length = list.Count;
            for(int i=0; i< length; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
