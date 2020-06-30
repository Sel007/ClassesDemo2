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

        //Constructors
        public Customer()
        {

        }

        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
