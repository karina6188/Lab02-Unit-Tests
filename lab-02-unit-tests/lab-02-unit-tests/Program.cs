using System;

namespace lab_02_unit_tests
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool ATM = true;
                while (ATM)
                {
                    ATM = StartATM();
                }

                static bool StartATM()
                {
                    Console.Clear();
                    Console.WriteLine("      ,gg,                               ,ggggggggggg,                                       ");
                    Console.WriteLine("     i8^^8i                             dP^^^88^^^^^^Y8,                           ,dPYb,    ");
                    Console.WriteLine("     `8,,8'                             Yb,  88      `8b                           IP'`Yb    ");
                    Console.WriteLine("      `88'                               ``  88,      8P                           I8  8I    ");
                    Console.WriteLine("      dP`8,                                  88aaaad8P^                            I8  8bgg, ");
                    Console.WriteLine("     dP' `8a  gg      gg   ,ggg,,ggg,        88^^^^Y8ba    ,gggg,gg   ,ggg,,ggg,   I8 dP^ ^8 ");
                    Console.WriteLine("    dP'   `Yb I8      8I  ,8^ `8P` ^8,       88      `8b  dP^  ^Y8I  ,8^ ^8P^ ^8,  I8d8bggP^ ");
                    Console.WriteLine("_ ,dP'     I8 I8,    ,8I  I8   8I   8I       88      ,8P i8'    ,8I  I8   8I   8I  I8P' ^Yb, ");
                    Console.WriteLine(" 888,,____,dP,d8b,  ,d8b,,dP   8I   Yb,      88_____,d8',d8,   ,d8b,,dP   8I   Yb,,d8    `Yb,");
                    Console.WriteLine("a8P^Y88888P^ 8P'^Y88P^`Y88P'   8I   `Y8     88888888P^  P^Y8888P^`Y88P'   8I   `Y888P      Y8");
                    Console.WriteLine("                                                                                             ");

                    Console.WriteLine("Select your transaction.");
                    Console.WriteLine("1) View Current Balance");
                    Console.WriteLine("2) Withdraw Money");
                    Console.WriteLine("3) Make Deposits");
                    Console.WriteLine("4) Sign Out");
                    string service = Console.ReadLine();
                    switch (service)
                    {
                        case "1":
                            ViewBalance();
                            return true;
                        case "2":
                            Console.WriteLine("Enter the amount you would like to withdraw.");
                            string withdrawal = Console.ReadLine();
                            Withdraw(withdrawal);
                            return true;
                        case "3":
                            Deposit();
                            return true;
                        case "4":
                            return false;
                        default:
                            Console.WriteLine("Your selection is not valid.");
                            Console.WriteLine("Please select again from the available transactions.");
                            Console.ReadLine();
                            return true;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("There is something wrong with the ATM processing.");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("You have successfully signed out.");
                Console.WriteLine("Thank you for using the ATM services.");
            }
        }

        public static decimal currentBalance = 12000;

        static void ViewBalance()
        {
            Console.WriteLine($"You current balance is {currentBalance}");
            Console.ReadLine();
        }

        static void Withdraw(string withdrawal)
        {
            try
            {
                decimal withdrawAmount = decimal.Parse(withdrawal);
                Console.WriteLine();
            }
            catch (FormatException e)
            {
                Console.WriteLine("You did not enter an amount. Please try again.");
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }

        static void Deposit()
        {
            Console.WriteLine();
        }
    }
}
