using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Class6
    {
        public void frequentNum()
        {
            Console.WriteLine("==========================Most Frequent Numner===================================");
            int count = 0;
            int tempCount = 0;
            int largestNum = 0;

            string temp = "";
            Console.WriteLine("Enter an array of numbers seperated by space: ");
            temp = Console.ReadLine();
            int[] arr = Array.ConvertAll(temp.Trim().Split(' '), Convert.ToInt32).ToArray();
            int length = arr.Length;

            for(int i=0; i<length; i++)
            {
                tempCount = 0;
                for(int j=0; j<length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        tempCount++;
                    }
                }
                if(count < tempCount)
                {
                    count = tempCount;
                    largestNum = arr[i];
                }
            }
            Console.WriteLine("The number " + largestNum + " occurs the most frequently (occuring " + count + " times)");
        }
    }
}
