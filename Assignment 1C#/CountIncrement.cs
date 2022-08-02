using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class CountIncrement
    {
        public void count()
        {
            Console.WriteLine("\n==============================Counting to 24=====================================\n");

            int temp = 24;
            string counting = "";
            for(int i = 0; i < 4; i++)
            {
                temp = temp / (i + 1);
                for(int j = 0; j <= temp; j++)
                {
                    if(j==temp)
                    {
                        counting += j * (i + 1);
                    }
                    else
                    {
                        counting += j * (i + 1) + ",";
                    }
                }
                temp = 24;
                Console.WriteLine(counting + "\n");
                counting = "";
            }
        }
    }
}
