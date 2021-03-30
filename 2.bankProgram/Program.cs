using System;
using System.Linq;

namespace bankProgram
{
    class Program
    {
        
        static void Main(string[] args)
        {
            CreateClient();
        }
        
        static void CreateClient()
        {
            Client client = new Client();
            Console.WriteLine(String.IsNullOrEmpty(client._name));
            Console.WriteLine(client._name);

            while (String.IsNullOrEmpty(client._name))
            {
                Console.WriteLine("please enter a name");
                client._name = Console.ReadLine();
                
                if(client._name.Any(char.IsDigit))
                {
                    Console.WriteLine("name may not contain numbers");
                    client._name = "";
                }
            }
            
            Console.WriteLine("please enter new client id");
            
             while (client._id==0)
             {
                 int clientId;
                 string idInput = Console.ReadLine();
                 if(int.TryParse(idInput, out clientId))
                 {
                     client._id = clientId;
                 }
                 else
                 {
                     Console.WriteLine("please enter a valid number");
                 };
             }
             client._dateJoined = DateTime.Now;
             Console.WriteLine("new client added at " + client._dateJoined );
             CreateBankAccount(client._id);
        }
        
        static void CreateBankAccount(int clientId)
        { 
            
         BankAccount bankAccount = new BankAccount(clientId);
         string option;
         
         Console.WriteLine("Select account type");
         bankAccount._type = Console.ReadLine();
         do
         {
             Console.WriteLine("What do you want to do?");
             Console.WriteLine("1. Open new account");
             Console.WriteLine("2. Check your balance");
             Console.WriteLine("3. Deposit on your account");
             Console.WriteLine("4. Withdrawal from your account");
             Console.WriteLine("5. exit");

             option = Console.ReadLine();
             switch (option)
             {
                 case "1":
                     Console.WriteLine("Enter name of new account type");
                     bankAccount._type = Console.ReadLine();
                     break;
                 case "2":
                     Console.WriteLine("Your current balance is:");
                     Console.WriteLine(bankAccount.CheckBalance());
                     break;
                 case "3":
                     Console.WriteLine("Enter how much you want to deposit ");
                     int amountDeposit;
                     if (int.TryParse(Console.ReadLine(), out amountDeposit))
                     {
                         bankAccount._balance += amountDeposit;
                     }
                     else
                     {
                         Console.WriteLine("please enter a valid number");
                     }

                     break;
                 case "4":
                     Console.WriteLine("Enter how much you want to withdrawal");
                     int amountWithdraw;
                     if (int.TryParse(Console.ReadLine(), out amountWithdraw))
                     {
                         if (bankAccount._balance - amountWithdraw >= 0)
                         {
                             bankAccount._balance -= amountWithdraw;
                         }
                         else
                         {
                             Console.WriteLine("you don't have enough money in your account");
                         }

                     }
                     else
                     {
                         Console.WriteLine("please enter a valid number");
                     }

                     break;
                 case "5":
                     Console.WriteLine("you selected exit");
                     break;
                 default:
                     Console.WriteLine("We didn't understand your question");
                     break;
             }

         } while (option != "5");

        }

        
    }
}
