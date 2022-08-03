using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Class7
    {
        public void reversePrint()
        {
            Console.WriteLine("==========================Print a string in reverse===================================");
            Console.WriteLine("Type a string: ");
            string temp = Console.ReadLine();
            char[] tempChar = temp.ToCharArray();
            Array.Reverse(tempChar);

            temp = "";
            for(int i = 0; i < tempChar.Length; i++)
            {
                temp += tempChar[i];
            }
            Console.WriteLine(temp);
        }
    }
}
