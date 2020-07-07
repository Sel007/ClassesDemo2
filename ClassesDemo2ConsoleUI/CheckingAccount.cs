using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ClassesDemo2ConsoleUI
{
    public class CheckingAccount : BankAccount
    {
        //Properties
        //public decimal Balance { get; set; }

        public decimal _balance;

        public decimal Balance
        {
            get => _balance;
            set
            {
                Console.WriteLine("Please enter your PIN number");
                string pin = Console.ReadLine();
                if (pin == "1234")
                {
                    _balance = value;
                }
                else
                {
                    Console.WriteLine("Not correct PIN");
                    return;
                }
            }
        }
        public string AccountNumber { get; set; }

        //Field = local class variable
        private string _routingNumber;
        public string RoutingNumber
        {
            get
            {
                return _routingNumber;
            }

            set
            {
                if (value.Length == 9)
                {
                    _routingNumber = value;
                }
                else
                {
                    Console.WriteLine("Invalid Routing Number");
                }
            }
        }

        public Customer Owner { get; set; }
        public void PrintBalance()
        {
            Console.WriteLine($"Your current balance is {Balance}");
        }
    }
}
