using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class SavingsAccount:Account
    {
        //fields
        private double withdrawl;
        private double deposit;
        private double balance;

        //properties
        protected double Withdrawl
        {
            get { return this.withdrawl; }
            set { this.withdrawl = value; }
        }
        protected double Deposit
        {
            get { return this.deposit; }
            set { this.deposit = value; }
        }
        protected double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        //constructors
        public SavingsAccount()
        {
            this.balance = Balance;
        }

        //methods
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Savings Account Balance: " + Balance);
        }
    }
}
