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
            Console.WriteLine();
            Console.WriteLine("Welcome to Trojan Bank, press enter to continue");



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

        }

        static void Deposit()
        {

        }

        static void Balance()
        {

        }

        static void Withdraw()
        {

        }

    }
}
