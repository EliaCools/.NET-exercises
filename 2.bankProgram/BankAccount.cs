using System;

namespace bankProgram
{
    public class BankAccount
    {

        public int client;
        public int balance;
        public string type;
        
        public int _client
        {
            get { return client; }
            set { client = value; }
        }
        public int _balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public string _type
        {
            get { return type; }
            set { type = value; }
        }
        public BankAccount( int clientId)
        {
           client = clientId;
        }

        public int CheckBalance()
        {
            return balance;
        }


        public void Withdraw(int amount)
        {

            var newBalance = this.balance - amount;

            this.balance = newBalance;

        }

        public void Deposit(int amount)
        {
            var newBalance = this.balance + amount;
            this.balance = newBalance;
        }
        
        
        
    }
}