



using ConsoleApp5.ClassList;
using System;
using System.Collections.Generic;

List<string> names = ["AbdulSamad", "AbdulJamilu", "Oluwatosin", "Augustine", "Pelumi"];
List<Customer> customers = new List<Customer>();
var atm = new Atm("Wema", 1000000m);
int customerPin;
Customer operatingCustomer = new Customer("", 0000, AccountType.Savings, 0);
decimal withdrawalAmount;
decimal balance;

foreach (string name in names)
{
    customers.Add(
        new Customer(
        name,
        new Random().Next(1000, 5000), // Generating customer pin
        AccountType.Savings,
        new Random().Next(10000, 50000) // Generating customer account balance
        ));
}

foreach (Customer customer in customers)
{
    Console.WriteLine(customer.Name);
    Console.WriteLine();
    Console.WriteLine(customer.Pin);
    Console.WriteLine();
    Console.WriteLine(customer.AccountBalance);
}

Console.WriteLine($"Welcome {atm.BankName} ATM");

Console.WriteLine("Please Input Your Pin");

customerPin = Convert.ToInt32(Console.ReadLine());

foreach (Customer customer in customers)
{
    if (customer.Pin == customerPin)
    {
        operatingCustomer = customer;
        Console.WriteLine(customer.Name);
    }

}

Console.WriteLine("Please Input Withdrawal Amount");
withdrawalAmount = Convert.ToDecimal(Console.ReadLine());

balance = operatingCustomer.Withdraw(withdrawalAmount);

if (balance < 0)
{
    Console.WriteLine("Insufficient Funds");
}
else
{
    Console.WriteLine($"{operatingCustomer.Name}  {withdrawalAmount} Successfully Withdrawn  new Account Balance is {operatingCustomer.AccountBalance}");
}



