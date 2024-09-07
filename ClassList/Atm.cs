using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.ClassList
{
    internal class Atm
    {
        public string BankName { get; set; }
        public decimal AtmBalance { get; set; }

        public Atm(string bankName, decimal atmBalance)
        {
            BankName = bankName;
            AtmBalance = atmBalance;
        }


    }
}
