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

            //Creating client account by asking user for Personal Info

            Console.WriteLine("To Create a Client Account,");
            Console.WriteLine("Enter your Full Name and Phone Number below:");
            Console.WriteLine();
            Console.WriteLine("Name:");
            client.AccountName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Phone:");
            client.PhoneNumber = Console.ReadLine();
            Console.WriteLine();

            do
            {
                MenuOptions();
                menuResponse = Console.ReadLine();

                
                switch (menuResponse)
                {
                    case "1":
                        // Client Personal Info
                        Console.WriteLine("--------------------------------------------------");
                        Console.WriteLine("Account Holder: " + client.AccountName);
                        Console.WriteLine("Phone Number: " + client.PhoneNumber);
                        Console.WriteLine();

                        //Client Account Number
                        Console.WriteLine("--------------------------------------------------");
                        Console.WriteLine("Account Number: " + client.AccountNumber);
                        Console.WriteLine("--------------------------------------------------");
                        Console.WriteLine();
                        break;

                    case "2":
                        //Client Account Balance
                        Console.WriteLine("--------------------------------------------------");
                        Console.WriteLine("Your Current Balance: $" + account.CurrentBalance);
                        Console.WriteLine("--------------------------------------------------");
                        Console.WriteLine();
                        break;

                    case "3":
                        //Deposit 
                        Console.WriteLine("Enter the amount you'd like to deposit: ");
                        decimal depositAmount = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("--------------------------------------------------");
                        account.Deposit(depositAmount);
                        Console.WriteLine("--------------------------------------------------");
                        Console.WriteLine();
                        break;

                    case "4":
                        //Withdraw
                        Console.WriteLine("Enter the amount you'd like to withdraw:");
                        decimal amount = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("--------------------------------------------------");
                        account.Withdraw(amount);
                        Console.WriteLine("--------------------------------------------------");
                        Console.WriteLine();

                        
                        break;

                    case "5":
                        //Upon Exiting the program, Client Transaction History andlast known Balance is stored in a text file using Stream Writer.
                        StreamWriter writer = new StreamWriter("AccountSummary.txt");
                        using (writer)
                        {

                            writer.WriteLine("------------------------------------------------------------------------------");
                            writer.WriteLine("                      Bank of America                                 ");
                            writer.WriteLine("-----------------------------------------------------------------------------");
                            writer.WriteLine();
                            writer.WriteLine("Account Holder: " + client.AccountName);
                            writer.WriteLine("Phone: " + client.PhoneNumber);
                            writer.WriteLine("Account Number: " + client.AccountNumber);
                            writer.WriteLine();
                            writer.WriteLine("Date / Time              + / -          BALANCE               ");
                            writer.WriteLine();

                            foreach (string tran in account.Transactions) //ForEach Loop that allows StreamWriter writer to write each line that was recorded to the list.
                            {
                                writer.WriteLine(tran);
                            }



                        }
                        Console.WriteLine("\a\a\a                       Process Ended"); //Cool Beeps
                        Console.WriteLine();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Not a valid entry.");
                        break;
                }
            } while (menuResponse != "5"); //Do While loop will repeat and re-executes Bank System menu until the user chooses to exit the program.
           
        }

               






            
        


           public static void Header()
        {   
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------(* BANK OF AMERICA *)------------------------------");
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
   
    


