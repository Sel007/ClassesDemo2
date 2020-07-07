using System;

namespace ClassesDemo2ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciating a new account = Creating a variable of the Bank Account data type.
            BankAccount a = new BankAccount();

            //Instanciating a customer = Creating a variable of the Customer data type.
            Customer c = new Customer();

            //Getting user input
            Console.WriteLine("Please give me your first name.");
            c.FirstName = Console.ReadLine();

            Console.WriteLine($"Thank you {c.FirstName}. Please give me your last name.");
            c.LastName = Console.ReadLine();

            //Printing customer info
            Console.Write($"Hello {c.FirstName} {c.LastName}");
            Console.WriteLine();

            //Getting user input
            Console.WriteLine("Please enter your age.");
            c.Age = int.Parse(Console.ReadLine());

            if (c.Age >= 18)
            {
                //Object Initializer Syntax
                CheckingAccount checkingAccount = new CheckingAccount
                {
                    //Setting properties for the Checking Account
                    RoutingNumber = "645978312",
                    AccountNumber = "2541234",
                    Owner = c
                };

                c.UserCheckingAccount = checkingAccount;

                Console.WriteLine($"Your checking account number is {checkingAccount.AccountNumber}");
                Console.WriteLine($"The owner of the account is: {c.FirstName} {c.LastName}");
            }

            else
            {
                Console.WriteLine("Sorry, you are too young to open an account on your own. Please come into one of our \nbank locations with a parent or guardian.");
                return;
            }

            Console.WriteLine("Do you want to deposit or withdraw money");
            string userResponse = Console.ReadLine();

            decimal amount;
            switch (userResponse)
            {
                case "deposit":
                    Console.WriteLine("How much?");
                    amount = decimal.Parse(Console.ReadLine());
                    c.Deposit(amount);
                    c.UserCheckingAccount.PrintBalance();
                    break;

                case "Withdraw":
                    Console.WriteLine("How much?");
                    amount = decimal.Parse(Console.ReadLine());
                    c.Withdraw(amount);
                    break;
            }

            Console.WriteLine("Do you want to open a Savings Account or apply for a Credit Card?");
            Console.WriteLine("Type s = Savings Account and type c = Credit Card: ");
            _ = Console.ReadLine();

            //if (inPut.ToLower() == "s")
            //{
            //    var sAcct = new SavingsAccount();

            //    sAcct.InterestRate = 
            //}


        }
    }
}
