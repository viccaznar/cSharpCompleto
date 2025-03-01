using System.Globalization;

namespace Course.Entities
{
    class Account
    {

        public int Number { get; protected set; }
        public String Holder { get; protected set; }
        public Double Balance { get; protected set; }

        public Account()
        { 
        }
        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void WithDraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }     

    }
}
