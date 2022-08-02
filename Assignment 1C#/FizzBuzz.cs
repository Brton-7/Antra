using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class FizzBuzz
    {
        int i = 1;
        public void buzzFizz()
        {
            Console.WriteLine("\n==========================Fizz Buzz==============================================\n");
            Console.WriteLine("Type a Number (0 to quit): ");
            while (i != 0)
            {
                string temp = Console.ReadLine();
                i = Convert.ToInt32(temp);
                if(i%3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(i%5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if(i%3 == 0 && i%5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
