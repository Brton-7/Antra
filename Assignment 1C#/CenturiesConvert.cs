using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Class2
    {
        public void dataTypedTime()
        {
            string temp;
            int centuries;
            int years = 100;
            uint days = 36524;
            long hours = 52594560;
            float minutes = 3155673600;
            float seconds = 3155673600000;
            float miliseconds = 3155673600000000;
            double microseconds = 4155673600000000000;
            double nanoseconds = 3154000000000000000;

            Console.WriteLine("\n==========================2. Centuries Converted============================\n");
            Console.WriteLine("Number in Centuries: ");
            temp = Console.ReadLine();
            centuries = Convert.ToInt32(temp);
            //string conversion = String.Format("Years: {0} Days: {1} Hours: {2} Minutes: {3}, Seconds: {4} Miliseconds: {5} Microseconds: {6} Nanoseconds {7}e+18", years*centuries, days*centuries, hours*centuries, minutes*centuries, seconds * centuries, miliseconds*centuries, microseconds*centuries, nanoseconds*centuries);
            Console.WriteLine("Number in Years: " + years * centuries);
            Console.WriteLine("Number in Days: " + days * centuries);
            Console.WriteLine("Number in Hours: " + hours * centuries);
            Console.WriteLine("Number in Minutes: " + minutes * centuries);
            Console.WriteLine("Number in Seconds: " + seconds * centuries);
            Console.WriteLine("Number in Miliseconds: " + miliseconds * centuries);
            Console.WriteLine("Number in Microseconds: " + microseconds * centuries);
            Console.WriteLine("Number in Nanoseconds: " + nanoseconds * centuries + "e+18");
        }
    }
}
