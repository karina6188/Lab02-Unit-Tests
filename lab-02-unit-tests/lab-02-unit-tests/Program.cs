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
                    Console.WriteLine("Select your transaction.");
                    Console.WriteLine("1) View Current Balance");
                    Console.WriteLine("2) Withdraw Money");
                    Console.WriteLine("3) Make Deposits");
                    Console.WriteLine("4) Sign Out");
                    string service = Console.ReadLine();
                    if (service == "1")
                    {
                        ViewBalance();
                        return true;
                    }
                    else if (service == "2")
                    {
                        Withdraw();
                        return true;
                    }
                    else if (service == "3")
                    {
                        Deposit();
                        return true;
                    }
                    else if (service == "4")
                    {
                        return false;
                    }
                    else
                    {
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

        static void ViewBalance()
        {
            Console.WriteLine();
        }

        static void Withdraw()
        {
            Console.WriteLine();
        }

        static void Deposit()
        {
            Console.WriteLine();
        }
    }
}
