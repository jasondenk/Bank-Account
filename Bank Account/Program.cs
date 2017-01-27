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
            CheckingAccount account = new CheckingAccount();
            //instantiate Checking Account
            CheckingAccount checkingAccount = new CheckingAccount();
            // Create an instance of StreamWriter to write to a Checking Account file
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

        //goto Start if invalid response
        Start:;
            //User Interface
            string input = "";
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
                if (input == "1")
                {
                    Console.WriteLine(account.ShowInfo());
                    Console.WriteLine("\n\n\nType any key to see menu.");
                    Console.ReadKey();
                }
                string accountBalance;
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
                    if (depositWithdraw == "1")
                    {
                        if (input == "3")
                        {
                            Console.WriteLine("Type amount to deposit and press enter:");
                            checkingAccount.Deposit = double.Parse(Console.ReadLine());
                            using (checking = File.AppendText(@"C:\Users\WeCanCodeIT\Documents\Visual Studio 2015\Projects\Bank Account\Bank Account\bin\Debug\CheckingAccount.txt"))
                            {
                                //add deposit/withdrawl and update balance
                                checking.WriteLine(DateTime.Now);
                                checking.WriteLine(checkingAccount.DepositMoney());
                            }

                        }
                        else if (input == "4")
                        {
                            Console.WriteLine("Type amount to withdraw and press enter:");
                            checkingAccount.Withdrawl = double.Parse(Console.ReadLine());
                            using (checking = File.AppendText(@"C:\Users\WeCanCodeIT\Documents\Visual Studio 2015\Projects\Bank Account\Bank Account\bin\Debug\CheckingAccount.txt"))
                            {
                                //add deposit/withdrawl and update balance
                                checking.WriteLine(DateTime.Now);
                                checking.WriteLine(checkingAccount.WithdrawMoney());
                            }
                        }
                    }
                    else if (depositWithdraw == "2")
                    {
                        if (input == "3")
                        {
                            Console.WriteLine("Type amount to deposit to reserve account and press enter:");
                            reserveAccount.Deposit = double.Parse(Console.ReadLine());
                            using (reserve = File.AppendText(@"C:\Users\WeCanCodeIT\Documents\Visual Studio 2015\Projects\Bank Account\Bank Account\bin\Debug\ReserveAccount.txt"))
                            {
                                //add deposit/withdrawl and update balance
                                reserve.WriteLine(DateTime.Now);
                                reserve.WriteLine(reserveAccount.DepositMoney());
                            }

                        }
                        else if (input == "4")
                        {
                            Console.WriteLine("Type amount to withdraw from reserve account and press enter:");
                            reserveAccount.Withdrawl = double.Parse(Console.ReadLine());
                            using (checking = File.AppendText(@"C:\Users\WeCanCodeIT\Documents\Visual Studio 2015\Projects\Bank Account\Bank Account\bin\Debug\ReserveAccount.txt"))
                            {
                                //add deposit/withdrawl and update balance
                                reserve.WriteLine(DateTime.Now);
                                reserve.WriteLine(reserveAccount.WithdrawMoney());
                            }
                        }
                    }
                    else if (depositWithdraw == "3")
                    {
                        if (input == "3")
                        {
                            Console.WriteLine("Type amount to deposit to savings account and press enter:");
                            savingsAccount.Deposit = double.Parse(Console.ReadLine());
                            using (savings = File.AppendText(@"C:\Users\WeCanCodeIT\Documents\Visual Studio 2015\Projects\Bank Account\Bank Account\bin\Debug\SavingsAccount.txt"))
                            {
                                //add deposit/withdrawl and update balance
                                savings.WriteLine(DateTime.Now);
                                savings.WriteLine(savingsAccount.DepositMoney());
                            }

                        }
                        else if (input == "4")
                        {
                            Console.WriteLine("Type amount to deposit to savings account and press enter:");
                            savingsAccount.Withdrawl = double.Parse(Console.ReadLine());
                            using (savings = File.AppendText(@"C:\Users\WeCanCodeIT\Documents\Visual Studio 2015\Projects\Bank Account\Bank Account\bin\Debug\SavingsAccount.txt"))
                            {
                                //add deposit/withdrawl and update balance
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
