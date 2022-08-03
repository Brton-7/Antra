using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Class1
    {
        int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        string array1;
        string array2;
        public void copyArray()
        {
            Console.WriteLine("==========================Copying an Array===================================");
            int[] newArr = new int[arr.Length];
            for (int i = 0; i<arr.Length; i++)
            {
                if(i == arr.Length-1)
                {
                    array1 += arr[i];
                    newArr[i] = arr[i];
                    array2 += newArr[i];
                    break;
                }
                array1 += arr[i] + ",";
                newArr[i] = arr[i];
                array2 += newArr[i] + ",";
            }
            Console.WriteLine("Original Array: " + array1);
            Console.WriteLine("Copied Array: " + array2);
        }

        static void Main(String[] args)
        {
            Class1 test1 = new Class1();
            test1.copyArray();

            Class2 test2 = new Class2();
            test2.listManagement();

            Class3 primes = new Class3();
            primes.print();

            Class4 rotate = new Class4();
            rotate.rotateArray();

            Class5 sequence = new Class5();
            sequence.longestSequence();

            Class6 frequentNum = new Class6();
            frequentNum.frequentNum();

            Class7 revChar = new Class7();
            revChar.reversePrint();

            Class8 revSen = new Class8();
            revSen.reverseSentence();
        }
    }
}
