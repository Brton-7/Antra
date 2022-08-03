using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Class4
    {
        public void rotateArray()
        {
            Console.WriteLine("==============================Rotating Array===================================");
            string temp = "";
            int k;
            Console.WriteLine("Enter an array of numbers seperated by space: ");
            temp = Console.ReadLine();
            int[] rArr = Array.ConvertAll(temp.Trim().Split(' '), Convert.ToInt32).ToArray();
            int length = rArr.Length;

            Console.WriteLine("Number of rotations (k): ");
            string temp2 = Console.ReadLine();
            k = Convert.ToInt32(temp2);

            int[] sumArr = new int[length];
            Array.Copy(rArr, sumArr, length);
            int[] newArr = new int[length];

            for (int j = 0; j < k; j++)
            {
                int temp3 = rArr[length - 1];
                newArr[0] = temp3;
                for (int i = length - 1; i > 0; i--)
                {
                    newArr[i] = rArr[i - 1];
                }
                for(int i = 0; i < length; i++)
                {
                    sumArr[i] += newArr[i];
                }
            }
            temp = "";
            for(int i = 0; i< length; i++)
            {
                temp += sumArr[i] + " ";
            }
            Console.WriteLine("Summed Array: " + temp);
        }
    }
}
