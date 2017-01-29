using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Account
    {
        //fields
        private string firstName ;
        private string lastName ;        
        private string accountNumber;

        //properties
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        
        public string AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }

        //constructors
        public Account()
        { }

        //methods
        public string ShowInfo()
        {
            return "Name: " + FirstName+" "+LastName + "    "+ "\nAccount Number: " + AccountNumber ;
        }

        public void AskFirstName()
        {
            Console.WriteLine("Type first name, hit enter: ");
            FirstName= Console.ReadLine();
        }
        public void AskLastName()
        {
            Console.WriteLine("Type last name, hit enter: ");
            LastName= Console.ReadLine();
        }
        public void AskAccountNumber()
        {
        TypeAccount:;
            Console.WriteLine("Type 8 digit account number, press enter: ");
            string input = Console.ReadLine();
            int toInt;
            if (input.Length!=8|| int.TryParse(input, out toInt) == false)
            {
                Console.WriteLine("Invalid.");
                Console.WriteLine("Type any key to try again.");
                Console.ReadKey();
                Console.Clear();
                goto TypeAccount;
                
            }
            AccountNumber=input;
        }
    }
}
