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
        private string firstName = "Yogi";
        private string lastName = "Bear";        
        private int accountNumber= 12345678;

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
        
        public int AccountNumber
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
            return "Name: " + FirstName+" "+LastName + "\nAccount Number: " + AccountNumber ;
        }


    }
}
