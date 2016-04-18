using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Banking_System
{
    class Program
    {
        static void Main(string[] args)
        {


            Client client = new Client();
            Account account = new Account();
            client.AccountNumber = Client.GenerateAccountNum();
           

           
           
            string menuResponse;
            //Program opening header
            Header();

            do
            {
                MenuOptions();
                menuResponse = Console.ReadLine();

                //START STUFF
                switch (menuResponse)
                {
                    case "1":
                        // Client info
                        Console.WriteLine("Account Holder: " + client.AccountName);
                        //Name
                        //Accout Number
                        Console.WriteLine("Account Number: " + client.AccountNumber);
                        Console.WriteLine("--------------------------------------------------");
                        


                        break;

                    case "2":
                        //Account Balance
                        Console.WriteLine("Your current balance: $" + account.CurrentBalance);
                        Console.WriteLine("--------------------------------------------------");

                        
                        break;
                    case "3":
                        //Deposit 
                        Console.WriteLine("Enter the amount you'd like to deposit: ");
                        decimal depositAmount = decimal.Parse(Console.ReadLine());
                        account.Deposit(depositAmount);
                        Console.WriteLine("--------------------------------------------------");
                        break;

                    case "4":
                        //Withdraw
                        Console.WriteLine("Enter the amount you'd like to withdraw:");
                        decimal amount = decimal.Parse(Console.ReadLine());
                        account.Withdraw(amount);
                        Console.WriteLine("--------------------------------------------------");

                        
                        break;

                    case "5":
                        //Exit
                        StreamWriter writer = new StreamWriter("AccountSummary.txt");
                        using (writer)
                        {

                            writer.WriteLine("------------------------------------------------------------------------------");
                            writer.WriteLine("                      BANK OF 'MURICA                                 ");
                            writer.WriteLine("-----------------------------------------------------------------------------");
                            writer.WriteLine();
                            writer.WriteLine("Account Holder: " + client.AccountName);
                            writer.WriteLine("Account Number: " + client.AccountNumber);
                            writer.WriteLine();
                            writer.WriteLine("Date / Time              + / -          BALANCE               ");
                            writer.WriteLine();

                            foreach (string tran in account.Transactions)
                            {
                                writer.WriteLine(tran);
                            }



                        }
                        Console.WriteLine("\a\a\a                       Fare Well!");
                        Console.WriteLine();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Not a valid entry!");
                        break;
                }
            } while (menuResponse != "5");
           
        }

               






            
        


           public static void Header()
        {   
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine(" $$$$$$$$$$$$$$$$$$$$$$$$$$$  (* BANK OF 'MURICA *)  $$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine();

        }

        public static void MenuOptions()

        {
            Console.WriteLine("Enter the number of the option you wish to execute:");

            Console.WriteLine();
            Console.WriteLine("\t(1.) \tClient Info");
            Console.WriteLine("\t(2.) \tAccount Balance");
            Console.WriteLine("\t(3.) \tDeposit");
            Console.WriteLine("\t(4.) \tWithdraw");
            Console.WriteLine("\t(5.) \tExit");
            Console.WriteLine();
        }
       
            
                    
            
        }
        
        
    }
   
    


