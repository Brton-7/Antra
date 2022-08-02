using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class ValidGuess
    {
        public void guessGame()
        {
            Console.WriteLine("\n==========================Guessing Game======================================\n");
            int correctNumber = new Random().Next(3) + 1;
            Console.WriteLine("Guess a number between 1 and 3");
            int guessedNumber = int.Parse(Console.ReadLine());
            if (guessedNumber == correctNumber)
            {
                Console.WriteLine("Correct Answer!");
            }
            else if (guessedNumber > correctNumber)
            {
                Console.WriteLine("You guessed high");
            }
            else
            {
                Console.WriteLine("You guessed low");
            }

        }
    }
}
