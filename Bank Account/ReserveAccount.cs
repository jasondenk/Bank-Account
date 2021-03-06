﻿using System;
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
        public double Withdrawl
        {
            get { return this.withdrawl; }
            set { this.withdrawl = value; }
        }
        public double Deposit
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
        public string ShowReserveInfo()
        {
            return "   " + "\nAccount Type: " + "Reserve";
        }
        //Shows balance
        public string ShowBalance()
        {
            return "Reserve Account Balance: $" + String.Format("{0:0.00}", Balance);
        }
        //returns string with deposit/balance
        public string DepositMoney()
        {
            balance = Balance + Deposit;
            return "+$" + String.Format("{0:0.00}", Deposit) + "\tReserve Account Balance: $" + String.Format("{0:0.00}", Balance);
        }
        //returns string with withdrawl/balance
        public string WithdrawMoney()
        {
            balance = Balance - Withdrawl;
            return "-$" + String.Format("{0:0.00}", Withdrawl) + "\tReserve Account Balance: $" + String.Format("{0:0.00}", Balance);
        }
    }
}
