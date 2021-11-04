using System;
using System.Text;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            // sets the name of the console
            Console.Title = "Trojan Bank Terminal";

            // sets the colour of the text
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Please enter your 4 digit pin: ");

            //stores the input as a string variable

            string pin = RequestPIN();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Welcome to Trojan Bank, press enter to continue");

            MainMenu();

            Console.ReadKey();
        }

        private static string RequestPIN()
        {
            StringBuilder sb = new StringBuilder();
            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey(true);

                if (!char.IsControl(keyInfo.KeyChar))
                {
                    sb.Append(keyInfo.KeyChar);
                    Console.Write("*");
                }
            } while (keyInfo.Key != ConsoleKey.Enter);
            {
                return sb.ToString();
            }

        }

        static void MainMenu()
        {
            // sets the name of the console
            Console.Title = "Trojan Bank Terminal";

            // sets the colour of the text
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("");
            Console.WriteLine("Options Menu");
            Console.WriteLine("");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Balance");
            Console.WriteLine("4. Exit");

            string choice;
            choice = Console.ReadLine();
        }

        static void Deposit()
        {
            // sets the name of the console
            Console.Title = "Trojan Bank Terminal";

            // sets the colour of the text
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("");
            Console.WriteLine("Deposits");
            Console.WriteLine("");

        }

        static void Balance()
        {
            // sets the name of the console
            Console.Title = "Trojan Bank Terminal";

            // sets the colour of the text
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("");
            Console.WriteLine("Current Balance");
            Console.WriteLine("");

        }

        static void Withdraw()
        {
            // sets the name of the console
            Console.Title = "Trojan Bank Terminal";

            // sets the colour of the text
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("");
            Console.WriteLine("Withdrawals");
            Console.WriteLine("");
        }

        static void Exit()
        {

        }

    }
}
