using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLast
{
    internal class Account
    {
        static int count = 0;
        protected string accountNumber;
        protected double balance;
        protected readonly DateTime dateOpend;
        protected string GenrateAccNum()
        {
            return $"MSN{++count}";
        }
        public double Balance { get { return balance; } set => balance = value; }
        public Account(double _balance)
        {
            this.balance = _balance;
            this.dateOpend = DateTime.Now;
            accountNumber = GenrateAccNum();
        }
        public virtual void Deposit(double amount)
        {
            if (amount > 0) { 
                balance += amount;
            }
            else
            {
                Console.WriteLine("Amount Must Be Greater Than 0");
            }
        }
        public virtual void Withdraw(double amount) {
            if (balance > 0) { 
                balance -= amount;
            }
            else { Console.WriteLine("You Dont Have Balance"); }
        }

        
    }
}
