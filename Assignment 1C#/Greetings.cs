using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class greetings
    {
        public void sendGreetings()
        {
            Console.WriteLine("\n=================================Greetings===================================\n");
            DateTime tempDate = new DateTime(2013, 9, 14, 22, 28, 0);
            DateTime current = DateTime.Now;
            int hours = current.Hour;
            
            if (hours > 3 && hours < 11)
            {
                Console.WriteLine("Good Morning");
            }
            else if (hours >= 11 && hours < 13)
            {
                Console.WriteLine("Good afternoon");
            }
            else if (hours >= 13 && hours < 20)
            {
                Console.WriteLine("Good Evening");
            }
            else
            {
                Console.WriteLine("Good Night");
            }
        }
    }
}
