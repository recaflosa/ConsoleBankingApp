using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    class Client
    {   //fields
        private string accountName = "Scott V Ladan";
        private int accountNumber;

        //properties

        public string AccountName
        {
            get { return this.accountName; }
            set { this.accountName = value; }
        }


        
        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }

        //Method
        public static int GenerateAccountNum()
        {
            Random random = new Random();
            int newNum = random.Next(1000, 90000);
            return newNum;            
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------

        //constructors


        public Client()
        {
           /* this.AccountNumber = 50483;*/
           //GenerateAccountNum();
            //this.AccountName = accountName;
        }
        
    }
}
