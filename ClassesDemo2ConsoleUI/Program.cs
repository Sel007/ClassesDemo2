using System;

namespace ClassesDemo2ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciating a customer = Creating a variable of the Customer data type.
            Customer c = new Customer();

            //Getting user input
            Console.WriteLine("Please give me your first name.");
            c.FirstName = Console.ReadLine();

            Console.WriteLine($"Thank you {c.FirstName}. Please give me your last name.");
            c.LastName = Console.ReadLine();

            //Printingt customer info
            Console.Write($"Hello {c.FirstName} {c.LastName}");
            Console.WriteLine();

            //Getting user input
            Console.WriteLine("Please enter your age.");
            c.Age = int.Parse(Console.ReadLine());

            if (c.Age < 18)
            {
                Console.WriteLine("Sorry, you are too young to open an account on your own. Please come into one of our \nbank locations with a parent or guardian.");
            }
            else
            {
                //Instanciating a Checking Account
                CheckingAccount checkingAccount = new CheckingAccount
                {

                    //Setting properties for the Checking Account
                    RoutingNumber = "645978312",
                    AccountNumber = "2541234",
                    Owner = c
                };
                Console.WriteLine($"Your checking account number is {checkingAccount.AccountNumber}");
                Console.WriteLine($"The owner of the account is: {c.FirstName} {c.LastName}");

                //Console.WriteLine(CheckingAccount.RoutingNumber);
            }

        }
    }
}
