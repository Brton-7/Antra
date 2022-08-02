using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class StarPrinter
    {
        public void printStars()
        {
            Console.WriteLine("\n=================================Star Pyramid==================================");
            int max = 5;
            int spaces = (max * 2) - 1;
            string starsOut = "";
            int tempStars = 0;
            for (int i = 0; i < max; i++)
            {
                for(int j = 0; j < spaces/2; j++)
                {
                    starsOut += " ";
                }
                for(int k= 0; k <= tempStars; k++)
                {
                    starsOut += "*";
                }
                Console.WriteLine(starsOut);
                starsOut = "";
                spaces -= 2;
                tempStars += 2;
            }
        }
    }
}
