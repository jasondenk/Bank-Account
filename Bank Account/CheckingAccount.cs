using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class CheckingAccount:Account
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
        public CheckingAccount()
        {
            this.balance = Balance;
        }

        //methods
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Check Account Balance: " + Balance);
            
        }
    }
}
