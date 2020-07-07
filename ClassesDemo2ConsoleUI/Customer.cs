using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesDemo2ConsoleUI
{
    public class Customer
    {
        //Properties = Member
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsApproved { get; set; }
        public CheckingAccount UserCheckingAccount { get; set; }
        public SavingsAccount UserSavingsAccount { get; set; }
        public Credit_Card UserCredit_Card { get; set; }

        //Constructors
        public Customer()
        {

        }

        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void Deposit(decimal amount)
        {
            UserCheckingAccount.Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            UserCheckingAccount.Balance -= amount;
        }
    }
}
