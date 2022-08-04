using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Class1
    {
        public int[] GenerateNumbers(int num)
        {
            int[] temp = new int[num];
            for(int i = 0; i < num; i++)
            {
                temp[i] = i + 1;
            }
            return temp;
        }
        public void PrintNumbers(int[] nums)
        {
            string temp = "";
            for (int i = 0; i < nums.Length; i++)
            {
                temp += nums[i] + " ";
            }
            Console.WriteLine("Your array: " + temp);
        }
        public void Reverse(int[] nums)
        {
            int temp;

            for(int i = 0; i < nums.Length/2; i++)
            {
                temp = nums[i];
                nums[i] = nums[nums.Length - i - 1];
                nums[nums.Length - i - 1] = temp;
            }
        }
        public void fibonacci(int num)
        {
            string temp = "";
            int[] fib = new int[num];
            fib[0] = fib[1] = 1;
            for(int i = 0; i < num; i++)
            {
                if(i > 1)
                {
                    fib[i] = fib[i - 1] + fib[i - 2];
                }
                temp += fib[i] + " ";
            }
            Console.WriteLine("fibonacci sequence up to " + num + ": " + temp);
        }
        static void Main(string[] args)
        {
            int num = 10;
            Class1 methods = new Class1();


            int[] numbers = methods.GenerateNumbers(num);
            methods.Reverse(numbers);
            methods.PrintNumbers(numbers);

            methods.fibonacci(num);
        }
    }
}
