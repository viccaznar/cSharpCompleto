namespace Course.Entities
{
    internal class SavingsAccount : Account
    {

        public Double InteresRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            :base(number, holder, balance)
        {
            InteresRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance = Balance * InteresRate;
        }


    }
}
