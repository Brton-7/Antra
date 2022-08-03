using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Class3
    {
        int[] arr = new int[10];
        public static int[] FindPrimesInRange(int startNum, int endNum)
        {
            int temp = endNum - startNum;
            int[] primes = new int[temp];
            int count = 1;
            primes[0] = 2;
            for(int i = startNum; i < endNum; i++)
            {
                if (i > 1)
                {

                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            break;
                        }
                        else
                        {
                            primes[count] = i;
                        }
                    }
                    count++;
                }
            }
            return primes;
        }
        public void print()
        {
            Console.WriteLine("==========================Print prime numbers in range===================================");
            string temp = "";
            arr = FindPrimesInRange(0, 20);
            for (int i= 0; i< 20; i++)
            {
                if (arr[i] > 0)
                {
                    temp += arr[i] + " ";
                }
            }
            Console.WriteLine("Primes from 1 to 10: " + temp);
        }
    }
}
