using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    class Account
    {
            //FIELDS
        private decimal currentBalance = 100.00M;
        private List<string> transactions = new List<string>();

        



       



        //PROPERTIES

        public decimal CurrentBalance
        {
            get { return currentBalance; }
            set { currentBalance = value; }
        } 

        public List<string> Transactions
        {
            get { return transactions; }
            set { transactions = value; }
        }


        //CONSTRUCT 
        public Account()
        {           
        }

        public Account(decimal balance)
        {
            this.CurrentBalance = balance;
        }




        //Methods
        //WITHDRAW
        public void Withdraw(decimal amountToWithdraw)
        {
            CurrentBalance = CurrentBalance - amountToWithdraw;
            Console.WriteLine("Balance is now: $" + CurrentBalance);
            string time = Convert.ToString(DateTime.Now);
            this.Transactions.Add(time + "\t - " + amountToWithdraw +" \t\t$" + CurrentBalance);
            
        }
        //DEPOSIT
        public void Deposit(decimal depositAmount)
        {
            CurrentBalance = CurrentBalance + depositAmount;
            Console.WriteLine("Balance is now: $" + CurrentBalance);
            string time = Convert.ToString(DateTime.Now);
            this.Transactions.Add(time + "\t + " + depositAmount + " \t\t$" + CurrentBalance);
            
        }

       
    }
    
    
}
