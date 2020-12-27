using Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Heranca3_CSharp {
    class Program {
        static void Main(string[] args) {
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500, 400));
            list.Add(new SavingsAccount(1003, "Bob", 500, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500, 500));

            double sum = 0;
            foreach (Account acc in list) {
                sum += acc.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("F2"));

            foreach (Account acc in list) {
                acc.Withdraw(10);
            }

            foreach (Account acc in list) {
                Console.WriteLine("Updated balance for account "
                + acc.Number
                + ": "
                + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
