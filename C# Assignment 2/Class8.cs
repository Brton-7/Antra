using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Class8
    {
        public void reverseSentence()
        {
            Console.WriteLine("==========================Print a sentence in reverse===================================");
            Console.WriteLine("Type a sentence: ");
            string temp = Console.ReadLine();
            char[] chars = { '.', ':', ';', '=', '(', ')', '&','[',']','"','/','!','?',' '};
            string revSen = String.Join(" ", temp.Split(chars).Reverse().ToString());

            Console.WriteLine(temp);
        }
    }
}
