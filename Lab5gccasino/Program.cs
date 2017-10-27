using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5gccasino
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus Casino!");
            bool run = true;
            while (run == true)
            {
                run = RollDice();
                
                Console.WriteLine("How many sides should each die have?");
                int numberSides = Int32.Parse(Console.ReadLine());

                Random roll = new Random();//initializes a Random class instance.
                int min = 1;
                int max = numberSides;

                Console.WriteLine("Your Roll:");
                int i = 0;
                while (i < 1)
                {   //this loop returns a Random value between 1 and the value of int numberSides
                    Console.WriteLine(roll.Next(min, max));//refers to the class Random and variable  roll
                    i++;
                    Console.WriteLine(roll.Next(min, max));//refers to the class Random and variable  roll
                    i++;
                    
                }

                run = DoAgain();
            }
            
        }
        public static bool RollDice()
        {
            Console.WriteLine("Roll the dice? (y/n)");
            string input = Console.ReadLine();
            input = input.ToLower();
            bool move;
            if (input == "y" || input == "yes" )
            {
                move = true;
            }
            else if (input == "n" || input == "no")
            {
                move = false;
                
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("That'a not a valid input. Try again");
                move = RollDice();
            }
            return move;
        }

        public static bool DoAgain()
        {
            Console.WriteLine("Want to play again? (y/n)");
            string input = Console.ReadLine();
            input = input.ToLower();
            bool move;
            if (input == "y" || input == "yes")
            {
                move = true;
            }
            else if (input == "n" || input == "no")
            {
                move = false;
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("That's not a valid input.  Try again");
                move = DoAgain();
            }
            return move;
        }

       /* public static int CheckInteger()
        {
            int i;
            while (!int.TryParse(Console.ReadLine(), out i))
            {
                Console.WriteLine("Invalid Entry: You must enter a number. ");
            }

            return i;

        }*/
           

    }
}
