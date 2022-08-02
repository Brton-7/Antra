using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Class1
    {
        public void byteSize()
        {
            string maxNumOfBytes = "";
            string minNumOfBytes = "";
            maxNumOfBytes = String.Format("[MAX] sbyte: {0}, byte: {1}, short: {2}, ushort: {3}, int: {4}, uint: {5}, long: {6}, ulong: {7}, float: {8}, double: {9}, decimal: {10}", 127, 255, 32767, 65535, 2147483647, 4294967295, 9223372036854775807 + "\n", 18446744073709551615, "+/-3.4e38", "+/-1.7e308", "+/-7.9e28");
            minNumOfBytes = String.Format("[MIN]sbyte: {0}, byte: {1}, short: {2}, ushort: {3}, int: {4}, uint: {5}, long: {6}, ulong: {7}, float: {8}, double: {9}, decimal: {10}", -128, 0, -32768, 0, -2147483648, 0, -9223372036854775808 + "\n", 0, "+/-1.0e-45", "+/-5e-324", "+/-1.0x10e-28");
            Console.WriteLine("\n=================================1. Byte Sizes===============================\n");
            Console.WriteLine(minNumOfBytes);
            Console.WriteLine(maxNumOfBytes);
            Console.WriteLine("\n=============================================================================\n");
        }
        static void Main(string[] args)
        {
            //Class1 bytes = new Class1();
            //bytes.byteSize();

            //Class2 centuries = new Class2();
            //centuries.dataTypedTime();

            //FizzBuzz fBuzz = new FizzBuzz();
            //fBuzz.buzzFizz();

            //ValidGuess gGame = new ValidGuess();
            //gGame.guessGame();

            //StarPrinter sPrint = new StarPrinter();
            //sPrint.printStars();

            Anniversery daysUntil = new Anniversery();
            daysUntil.ageAndAnniversery();

            greetings greet = new greetings();
            greet.sendGreetings();
            CountIncrement nums = new CountIncrement();
            nums.count();
        }

    }
}
