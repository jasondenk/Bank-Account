using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate Checking Account
            CheckingAccount checkingAccount = new CheckingAccount();
            // Create an instance of StreamWriter to write to a file
            StreamWriter checking = new StreamWriter(@"C:\Users\WeCanCodeIT\Documents\Visual Studio 2015\Projects\Bank Account\Bank Account\bin\Debug\CheckingAccount.txt");
            //the using statement will auto-close the file for us
            using (checking)
            {
                //write name and account #
                checking.WriteLine(checkingAccount.ShowInfo());
            }

            //instantiate Savings Account
            SavingsAccount savingsAccount = new SavingsAccount();
            // Create an instance of StreamWriter to write to a file
            StreamWriter savings = new StreamWriter(@"C:\Users\WeCanCodeIT\Documents\Visual Studio 2015\Projects\Bank Account\Bank Account\bin\Debug\SavingsAccount.txt");
            //the using statement will auto-close the file for us
            using (savings)
            {
                //write name and account #
                savings.WriteLine(savingsAccount.ShowInfo());
            }

            //instantiate Reserve Account
            CheckingAccount reserveAccount = new CheckingAccount();
            // Create an instance of StreamWriter to write to a file
            StreamWriter reserve = new StreamWriter(@"C:\Users\WeCanCodeIT\Documents\Visual Studio 2015\Projects\Bank Account\Bank Account\bin\Debug\ReserveAccount.txt");
            //the using statement will auto-close the file for us
            using (reserve)
            {
                //write name and account #
                reserve.WriteLine(reserveAccount.ShowInfo());
            }

            //Checking Deposit/Withdrawl
            using (checking = File.AppendText(@"C:\Users\WeCanCodeIT\Documents\Visual Studio 2015\Projects\Bank Account\Bank Account\bin\Debug\CheckingAccount.txt"))
            {
                //add deposit/withdrawl and update balance
                checking.WriteLine();
                checking.WriteLine(checkingAccount.DepositMoney());
                checking.WriteLine(checkingAccount.WithdrawMoney());
            }

            //Savings Deposit/Withdrawl
            using (savings = File.AppendText(@"C:\Users\WeCanCodeIT\Documents\Visual Studio 2015\Projects\Bank Account\Bank Account\bin\Debug\SavingsAccount.txt"))
            {
                //add deposit/withdrawl and update balance
                savings.WriteLine();
                savings.WriteLine(checkingAccount.DepositMoney());
                savings.WriteLine(checkingAccount.WithdrawMoney());
            }

            //Checking Deposit/Withdrawl
            using (reserve = File.AppendText(@"C:\Users\WeCanCodeIT\Documents\Visual Studio 2015\Projects\Bank Account\Bank Account\bin\Debug\ReserveAccount.txt"))
            {
                //add deposit/withdrawl and update balance
                reserve.WriteLine();
                reserve.WriteLine(checkingAccount.DepositMoney());
                reserve.WriteLine(checkingAccount.WithdrawMoney());
            }
        }
    }
}
