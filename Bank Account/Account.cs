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
        private string firstName;
        private string lastName;
        private string fullName;
        private int accountNumber;

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
        public string FullName
        {
            get { return this.fullName; }
            set { this.fullName = FirstName + " " + LastName; }
        }
        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }

        //constructors

        //methods
        public virtual void ShowInfo()
        {
            Console.WriteLine("Owner: " + FullName);
            Console.WriteLine("Account Number: " + AccountNumber);
        }

    }
}
