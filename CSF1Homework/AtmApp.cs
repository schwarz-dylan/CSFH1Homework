using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class AtmApp
    {
        static void Main(string[] args)
        {
            Console.Title = "ATM APPLICATION";
            Console.WriteLine("ATM APPLICATION");
            bool continueTransaction = true;
            bool loginAttemptsExceeded = false;
            bool correctAccountNumberEntered = false;
            bool pinNumberNotEntered = true;
            int loginAttempts = 0;
            Dictionary<string, string> account = new Dictionary<string, string>();
            account.Add("12345", "pin");
            account.Add("12346", "pin2");

            while (!correctAccountNumberEntered)
            {
                loginAttempts++;
                Console.WriteLine("Enter an account number: ");
                string accountNumber = Console.ReadLine();

                foreach (string accNumber in account.Keys)
                {
                    if (accountNumber.Equals(accNumber)) {
                        correctAccountNumberEntered = true;
                        Console.WriteLine("Account Found");

                        // Step 2
                        while (pinNumberNotEntered)
                        {
                            Console.WriteLine("Enter PIN: ");
                            string pinNumber = Console.ReadLine();

                            foreach (string pin in account.Values)
                            {
                                if (pinNumber.Equals(pin) && account[accNumber].Equals(pin))
                                {
                                    pinNumberNotEntered = false;
                                    Console.WriteLine("PIN Found");

                                    // Step 3
                                    while (continueTransaction)
                                    {
                                        Console.WriteLine("What would you like to do?");
                                        Console.WriteLine("Enter 1 for deposit: ");
                                        Console.WriteLine("Enter 2 for withdraw: ");
                                        Console.WriteLine("Enter 3 to exit: ");

                                        string userChoice = Console.ReadLine();

                                        switch (userChoice)
                                        {
                                            case "1":
                                                //step 4
                                                
                                                
                                                Console.WriteLine("How much do you wish to deposit? ");
                                                Console.WriteLine(Console.ReadLine() + " is the amount that will be deposited into account number " + accNumber );
                                                Console.WriteLine("Do you wish to make another transaction?Enter Y/N:  ");
                                                if (Console.ReadLine().ToLower().Equals("n")) 
                                                {
                                                    continueTransaction = false;
                                                }//end if
                                                break;
                                            case "2":
                                                //step 5
                                                
                                                
                                                Console.WriteLine("How much do you wish to withdraw? ");
                                                Console.WriteLine(Console.ReadLine() + " is the amount that will be withdrawn to the account number " + accNumber);
                                                Console.WriteLine("Do you wish to make another transaction? Enter Y/N: ");
                                                if (Console.ReadLine().ToLower().Equals("n")) 
                                                {
                                                    continueTransaction = false;
                                                }
                                                break;
                                            case "3":
                                                //step 7
                                                continueTransaction = false;
                                                
                                                break;
                                            default:
                                                break;
                                        }//end switch

                                    }//end while
                                    Console.WriteLine("Thank you for your business there will be a $3.50 charge to your account.");

                                }//end if
                            }//end foreach
                        }//end while
                        

                    }//end if
                }//end foreach

                if (loginAttempts > 5)
                {
                    Console.WriteLine("You have exceeded the maximum amount of login attempts.");
                    loginAttemptsExceeded = true;
                }
                if (loginAttemptsExceeded)
                    break;
                 
                //1-A                
            }




        }//end main()
    }//end class
}//end namespace
