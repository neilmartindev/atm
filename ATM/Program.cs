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

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    Deposit();
                    break;
                case "2":
                    Console.Clear();
                    Withdraw();
                    break;
                case "3":
                    Console.Clear();
                    Balance();
                    break;
                case "4":
                    Console.Clear();
                    Exit();
                    break;
            }



        }

        static void Deposit()
        {
            // sets the name of the console
            decimal balance = 1800;
            Console.Title = "Trojan Bank Terminal";

            // sets the colour of the text
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("Deposits");
            Console.WriteLine("");
            Console.WriteLine("Please enter the amount you wish to deposit(£): ");

            string deposit;
            deposit = Console.ReadLine();

            Console.WriteLine("Successfull deposit of £" + deposit);
        }

        static void Balance()
        {
            string balance = "£1800";

            // sets the name of the console
            Console.Title = "Trojan Bank Terminal";

            // sets the colour of the text
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("");
            Console.WriteLine("Current Balance");
            Console.WriteLine("");
            Console.WriteLine("Your current balance is: " + balance);
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

            string withdrawal;
            withdrawal = Console.ReadLine();

            Console.WriteLine("Successfull withdrawal of £" + withdrawal);
        }

        static void Exit()
        {
            Environment.Exit(0);
        }

    }
}
