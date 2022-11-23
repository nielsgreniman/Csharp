using System;

namespace CasinoGuy
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            double odds = 0.15;
            Guy player = new Guy() { Cash = 100, Name = "The player" };



            Console.WriteLine("Welcome to the casino! The odds are " + odds);
            while (player.Cash > 0)
            {
                player.MyInfo();

                Console.WriteLine("How much do you want to bet?");

                string howMuch = Console.ReadLine();
                if (int.TryParse(howMuch, out int amount))
                {
                    int pot = player.GiveCash(amount) * 2;

                    if (pot > 0)
                        {
                            if (random.NextDouble() > odds)
                        {
                            int winnings = pot;
                            player.ReceiveCash(winnings);
                            Console.WriteLine("You win " + winnings);
                        }
                    else
                        {
                            Console.WriteLine("You lose");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
            Console.WriteLine("The house always wins :-)");
        }
    }
}
