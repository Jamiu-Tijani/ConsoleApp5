using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.ClassList
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Pin { get; set; }
        public AccountType AccountType { get; set; }
        public decimal AccountBalance { get; set; }

        public Customer(string name, int pin, AccountType accountType, decimal accountBalance)
        {
            Name = name;
            Pin = pin;
            AccountType = accountType;
            Id = new Random().Next(0, 15);
            AccountBalance = accountBalance;
        }

        public decimal Withdraw(decimal amount)
        {
            if (amount > AccountBalance)
            {
                return -1;
            }
            else if (amount <= AccountBalance)
            {
                AccountBalance = AccountBalance - amount;
                return AccountBalance;
            }
            return AccountBalance;

        }
    }
}
