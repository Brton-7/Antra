using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Class2
    {
        public void listManagement()
        {
            Console.WriteLine("==========================List Management===================================");
            Console.WriteLine("Enter command |+ item | - item | -- clear | x to quit |");
            string command = "";
            string list = "";

            while (command != "x")
            {
                command = Console.ReadLine();
                if(command == "--")
                {
                    list = "";
                }
                else if (command.StartsWith("+"))
                {
                    command.Replace("+", "");
                    command.Trim();
                    list += command + "\n";
                }
                else if(command.StartsWith("-"))
                {
                    command.Remove(0, 1);
                    command.Trim();
                    Console.WriteLine(command);
                    int length = command.Length;
                    int temp = list.IndexOf(command);
                    if(temp >= 0)
                    {
                        list.Remove(temp, temp + length);
                    }
                }
                list.Replace("+", "");
                Console.WriteLine("Current List: \n" + list);
            }
        }
    }
}
