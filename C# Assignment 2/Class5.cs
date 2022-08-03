using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Class5
    {
        public void longestSequence()
        {
            int count = 1;
            int tempCount = count;
            Console.WriteLine("==========================Find longest sequence of equal elements===================================");
            string temp = "";
            Console.WriteLine("Enter an array of numbers seperated by space: ");
            temp = Console.ReadLine();
            int[] arr = Array.ConvertAll(temp.Trim().Split(' '), Convert.ToInt32).ToArray();
            int length = arr.Length;
            int currSequence = arr[0];
            int longSequence = currSequence;

            for(int i=1; i<length; i++)
            {
                if (arr[i] != currSequence)
                {
                    tempCount = 0;
                    currSequence = arr[i]; 
                }
                if(tempCount > count)
                {
                    count = tempCount;
                    longSequence = currSequence;
                }
                tempCount++;
            }
            temp = "";
            for(int i=0; i< length; i++)
            {
                if(arr[i] == longSequence)
                {
                    temp += arr[i] + " ";
                }
            }
            Console.WriteLine("Longest sequence: " + temp);
        }
    }
}
