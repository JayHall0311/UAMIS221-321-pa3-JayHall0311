using System;

namespace UAMIS221_321_pa3_JayHall0311
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int myInt = randomNumber.Next(6);
            myInt = myInt + 1;
            MenuSelection();
        }

        static void MenuSelection()
        {
            Console.WriteLine("Please select a game to play. \n 1) Pig \n 2) Blackjack \n 3) Exit");
            int userSelection = int.Parse(Console.ReadLine());
            if(userSelection == 1)
            {
                PigGame();
            }
            else if(userSelection == 2)
            {
                BlackjackGame();
            }
            else if(userSelection == 3)
            {
                Console.WriteLine("Thank you for playing!");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid selection, please try again.");
                MenuSelection();
            }

        }

        static void PigGame()
        {
            Console.WriteLine("Enter '1' to roll to see who will play first.");
        }

        static void BlackjackGame()
        {
            Console.WriteLine("Let's play some Blackjack!");
        }
    }
}
