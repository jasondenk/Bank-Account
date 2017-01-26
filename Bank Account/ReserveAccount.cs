using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class ReserveAccount:Account
    {
        //fields
        private double withdrawl;
        private double deposit;
        private double balance=0;

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
        public ReserveAccount()
        {
            this.balance = Balance;
        }

        //methods
        //Shows Account  name/number
        public override string ShowInfo()
        {
            return base.ShowInfo() + "\nAccount Type: " + "Reserve";
        }
        //Shows balance
        protected void ShowBalance()
        {            
            Console.WriteLine("Reserve Account Balance: " + Balance);
        }
        //returns string with deposit/balance
        public string DepositMoney()
        {
            balance = Balance + Deposit;
            return "+$" + Deposit + "\tChecking Account Balance: " + balance;
        }
        //returns string with withdrawl/balance
        public string WithdrawMoney()
        {
            balance = Balance - Withdrawl;
            return "-$" + Withdrawl + "\tChecking Account Balance: " + balance;
        }
    }
}
