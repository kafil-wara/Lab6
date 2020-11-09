using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;

namespace LabTask6
{
    class Account
    {
        string accName;
        string accId;
        int balance;

        Account()
        {
            Console.WriteLine("Default Acc Constructor");
        }

        Account(string accName, string accId, int balance)
        {
            this.accName = accName;
            this.accId = accId;
            this.balance = balance;
        }
        public void Deposit(int amount)
        {
            balance = balance + amount;
        }

        public void Withdraw(int amount)
        {
            if (amount < balance)

                balance = balance - amount;

            else
                Console.WriteLine("Insufficient Funds!");
        }

        public void Transfer(int amount, Account receiver)
        {
            if (amount < balance)
            {
                balance = balance - amount;
                receiver.balance = receiver.balance + amount;
            }
            else
                Console.WriteLine("Insufficient Funds!");

        }

    }
}
