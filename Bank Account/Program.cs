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
            //instantiate Account
            Account account = new Account();
            //Gets name/number of account
            account.AskFirstName();
            account.AskLastName();
            account.AskAccountNumber();
            //instantiate Checking Account
            CheckingAccount checkingAccount = new CheckingAccount();
            // Create an instance of StreamWriter to write to a Checking Account file
            StreamWriter checking = new StreamWriter(@"C:\Users\WeCanCodeIT\Documents\Visual Studio 2015\Projects\Bank Account\Bank Account\bin\Debug\CheckingAccount.txt");
            //writes name and account number automatically when program starts, the using statement will auto-close the file for us
            using (checking)
            {
                //write name and account #
                checking.WriteLine(account.ShowInfo()+checkingAccount.ShowCheckingInfo());
            }
            //instantiate Savings Account
            SavingsAccount savingsAccount = new SavingsAccount();
            // Create an instance of StreamWriter to write to a file
            StreamWriter savings = new StreamWriter(@"C:\Users\WeCanCodeIT\Documents\Visual Studio 2015\Projects\Bank Account\Bank Account\bin\Debug\SavingsAccount.txt");
            //writes name and account number automatically when program starts, the using statement will auto-close the file for us
            using (savings)
            {
                //write name and account #
                savings.WriteLine(account.ShowInfo() + savingsAccount.ShowSavingsInfo());
            }
            //instantiate Reserve Account
            ReserveAccount reserveAccount = new ReserveAccount();
            // Create an instance of StreamWriter to write to a file
            StreamWriter reserve = new StreamWriter(@"C:\Users\WeCanCodeIT\Documents\Visual Studio 2015\Projects\Bank Account\Bank Account\bin\Debug\ReserveAccount.txt");
            //writes name and account number automatically when program starts, the using statement will auto-close the file for us
            using (reserve)
            {
                //write name and account #
                reserve.WriteLine(account.ShowInfo() + reserveAccount.ShowReserveInfo());
            }

        //goto Start if invalid response
        Start:;
            string input = "";
            //User Interface
            while (input != "5")
            {
                Console.Clear();
                Console.WriteLine("Welcome. ");
                Console.WriteLine("1)View Client Information");
                Console.WriteLine("2)View Acount Balance");
                Console.WriteLine("3)Deposit Funds");
                Console.WriteLine("4)Withdraw Funds");
                Console.WriteLine("5)Exit");
                Console.WriteLine("Type option number and press enter: ");
                input = Console.ReadLine();

                //checks for valid input
                if (input != "1" && input != "2" && input != "3" && input != "4" && input != "5")
                {
                    Console.WriteLine("Please enter a valid input.");
                    Console.WriteLine("\nPress any key to continue.");
                    Console.ReadKey();
                    goto Start;
                }
                //Show Account name and number
                if (input == "1")
                {
                    Console.WriteLine("\n\n");
                    Console.WriteLine(account.ShowInfo());
                    Console.WriteLine("\n\n\nType any key to see menu.");
                    Console.ReadKey();
                }
                string accountBalance;
                //Show account balance
                if (input == "2")
                {
                    Console.Clear();
                    Console.WriteLine("1)Checking Account Balance");
                    Console.WriteLine("2)Reserve Account Balance");
                    Console.WriteLine("3)Savings Account Balance");
                    accountBalance = Console.ReadLine();
                    if (accountBalance != "1" & accountBalance != "2" & accountBalance != "3")
                    {
                        Console.WriteLine("Please enter a valid input.");
                        Console.WriteLine("\nPress any key to continue.");
                        Console.ReadKey();
                        goto Start;
                    }
                    if (accountBalance == "1")
                    {
                        Console.WriteLine(checkingAccount.ShowBalance());
                        Console.WriteLine("\n\n\nType any key to see menu.");
                        Console.ReadKey();
                    }
                    else if (accountBalance == "2")
                    {
                        Console.WriteLine(reserveAccount.ShowBalance());
                        Console.WriteLine("\n\n\nType any key to see menu.");
                        Console.ReadKey();
                    }
                    else if (accountBalance == "3")
                    {
                        Console.WriteLine(savingsAccount.ShowBalance());
                        Console.WriteLine("\n\n\nType any key to see menu.");
                        Console.ReadKey();
                    }
                }
                string depositWithdraw;
                //deposit or withdraw
                if (input == "3" || input == "4")
                {
                    Console.Clear();
                    Console.WriteLine("Select account to deposit/withdraw.");
                    Console.WriteLine("1)Checking");
                    Console.WriteLine("2)Reserve");
                    Console.WriteLine("3)Savings");
                    depositWithdraw = Console.ReadLine();
                    if (depositWithdraw != "1" & depositWithdraw != "2" & depositWithdraw != "3")
                    {
                        Console.WriteLine("Please enter a valid input.");
                        Console.WriteLine("\nPress any key to continue.");
                        Console.ReadKey();
                        goto Start;
                    }
                    //deposit/withdraw from checking
                    if (depositWithdraw == "1")
                    {
                        //deposit
                        if (input == "3")
                        {
                            CheckingDeposit:;
                            Console.WriteLine("Type amount to deposit to checking account and press enter:");
                            string transaction = Console.ReadLine();
                            double toDouble;
                            //checks for valid deposit
                            if(double.TryParse(transaction, out toDouble)==false||double.Parse(transaction)<0)
                            {
                                Console.WriteLine("Enter a valid deposit.");
                                Console.WriteLine("\nPress any key to continue.");
                                Console.ReadKey();
                                Console.Clear();
                                goto CheckingDeposit;
                            }
                            //updates deposit value in Checking Account Class                            
                            checkingAccount.Deposit = double.Parse(transaction);
                            using (checking = File.AppendText(@"C:\Users\WeCanCodeIT\Documents\Visual Studio 2015\Projects\Bank Account\Bank Account\bin\Debug\CheckingAccount.txt"))
                            {
                                //deposit and update balance
                                checking.WriteLine(DateTime.Now);
                                checking.WriteLine(checkingAccount.DepositMoney());
                            }
                        }
                        //withdraw
                        else if (input == "4")
                        {
                            CheckingWithdrawl:;
                            Console.WriteLine("Type amount to withdraw from checking account and press enter:");
                            string transaction = Console.ReadLine();
                            double toDouble;
                            //checks for valid deposit
                            if(double.TryParse(transaction, out toDouble)==false || double.Parse(transaction) < 0)
                            {
                                Console.WriteLine("Enter a valid amount to withdraw.");
                                Console.WriteLine("\nPress any key to continue.");
                                Console.ReadKey();
                                Console.Clear();
                                goto CheckingWithdrawl;
                            }
                            //updates withdrawl value in Checking Account Class
                            checkingAccount.Withdrawl = double.Parse(transaction);
                            using (checking = File.AppendText(@"C:\Users\WeCanCodeIT\Documents\Visual Studio 2015\Projects\Bank Account\Bank Account\bin\Debug\CheckingAccount.txt"))
                            {
                                //withdrawl and update balance
                                checking.WriteLine(DateTime.Now);
                                checking.WriteLine(checkingAccount.WithdrawMoney());
                            }
                        }
                    }
                    //deposit/withdraw from reserve account
                    else if (depositWithdraw == "2")
                    {
                        //deposit
                        if (input == "3")
                        {
                        ReserveDeposit:;
                            Console.WriteLine("Type amount to deposit to reserve account and press enter:");
                            string transaction = Console.ReadLine();
                            double toDouble;
                            //checks for valid deposit
                            if (double.TryParse(transaction, out toDouble) == false || double.Parse(transaction) < 0)
                            {
                                Console.WriteLine("Enter a valid deposit.");
                                Console.WriteLine("\nPress any key to continue.");
                                Console.ReadKey();
                                Console.Clear();
                                goto ReserveDeposit;
                            }
                            //updates deposit value in Reserve Account Class                            
                            reserveAccount.Deposit = double.Parse(transaction);                            
                            using (reserve = File.AppendText(@"C:\Users\WeCanCodeIT\Documents\Visual Studio 2015\Projects\Bank Account\Bank Account\bin\Debug\ReserveAccount.txt"))
                            {
                                //deposit and update balance
                                reserve.WriteLine(DateTime.Now);
                                reserve.WriteLine(reserveAccount.DepositMoney());
                            }

                        }
                        //withdraw
                        else if (input == "4")
                        {
                        ReserveWithdrawl:;
                            Console.WriteLine("Type amount to withdraw from reserve account and press enter:");
                            string transaction = Console.ReadLine();
                            double toDouble;
                            //checks for valid withdraw
                            if (double.TryParse(transaction, out toDouble) == false || double.Parse(transaction) < 0)
                            {
                                Console.WriteLine("Enter a valid amount to withdraw.");
                                Console.WriteLine("\nPress any key to continue.");
                                Console.ReadKey();
                                Console.Clear();
                                goto ReserveWithdrawl;
                            }
                            //updates withdrawl value in Reserve Account Class
                            reserveAccount.Withdrawl = double.Parse(transaction);                            
                            using (reserve = File.AppendText(@"C:\Users\WeCanCodeIT\Documents\Visual Studio 2015\Projects\Bank Account\Bank Account\bin\Debug\ReserveAccount.txt"))
                            {
                                //withdrawl and update balance
                                reserve.WriteLine(DateTime.Now);
                                reserve.WriteLine(reserveAccount.WithdrawMoney());
                            }
                        }
                    }
                    //deposit/withdraw from savings account
                    else if (depositWithdraw == "3")
                    {
                        if (input == "3")
                        {
                        SavingsDeposit:;
                            Console.WriteLine("Type amount to deposit to savings account and press enter:");
                            string transaction = Console.ReadLine();
                            double toDouble;
                            //checks for valid deposit
                            if (double.TryParse(transaction, out toDouble) == false || double.Parse(transaction) < 0)
                            {
                                Console.WriteLine("Enter a valid deposit.");
                                Console.WriteLine("\nPress any key to continue.");
                                Console.ReadKey();
                                Console.Clear();
                                goto SavingsDeposit;
                            }
                            //updates deposit value in Savings Account Class                            
                            savingsAccount.Deposit = double.Parse(transaction);
                            using (savings = File.AppendText(@"C:\Users\WeCanCodeIT\Documents\Visual Studio 2015\Projects\Bank Account\Bank Account\bin\Debug\SavingsAccount.txt"))
                            {
                                //deposit and update balance
                                savings.WriteLine(DateTime.Now);
                                savings.WriteLine(savingsAccount.DepositMoney());
                            }

                        }
                        else if (input == "4")
                        {
                        SavingsWithdrawl:;
                            Console.WriteLine("Type amount to withdraw from savings account and press enter:");
                            string transaction = Console.ReadLine();
                            double toDouble;
                            //checks for valid deposit
                            if (double.TryParse(transaction, out toDouble) == false || double.Parse(transaction) < 0)
                            {
                                Console.WriteLine("Enter a valid amount to withdraw.");
                                Console.WriteLine("\nPress any key to continue.");
                                Console.ReadKey();
                                Console.Clear();
                                goto SavingsWithdrawl;
                            }
                            //updates withdrawl value in Savings Account Class
                            savingsAccount.Withdrawl = double.Parse(transaction);                            
                            using (savings = File.AppendText(@"C:\Users\WeCanCodeIT\Documents\Visual Studio 2015\Projects\Bank Account\Bank Account\bin\Debug\SavingsAccount.txt"))
                            {
                                //withdrawl and update balance
                                savings.WriteLine(DateTime.Now);
                                savings.WriteLine(savingsAccount.WithdrawMoney());
                            }
                        }
                    }
                }
            }
            //exit while loop
            
        }
    }
}
