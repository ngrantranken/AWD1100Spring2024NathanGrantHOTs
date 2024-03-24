namespace LoanLibrary
{
    public interface ILoan
    {
        string Name { get; }
        string Type { get; }
        double Balance { get; }
        void MakePayment();
        void ApplyInterest();
    }

    public class ShortTermLoan : ILoan
    {
        public string Name { get; }
        public string Type { get; }
        public double Balance { get; private set; }

        private double monthlyPayment = 450;
        private double interestRate = 0.10;

        public ShortTermLoan(string name, double initialBalance)
        {
            Name = name;
            Type = "Short Term";
            Balance = initialBalance;
        }

        public void MakePayment()
        {
            if (monthlyPayment >= Balance)
            {
                Balance -= Balance;
            }
            else
            {
                Balance -= monthlyPayment;
            }
        }

        public void ApplyInterest()
        {
            Balance *= (1 + interestRate);
        }

    }

    public class LongTermLoan : ILoan
    {
        public string Name { get; }
        public string Type { get; }
        public double Balance { get; private set; }

        private double monthlyPayment = 200;
        private double interestRate = 0.05;

        public LongTermLoan(string name, double initialBalance)
        {
            Name = name;
            Type = "Long Term";
            Balance = initialBalance;
        }

        public void MakePayment()
        {
            if (monthlyPayment > Balance)
            {
                Balance -= Balance;
            }
            else
            {
                Balance -= monthlyPayment;
            }
        }

        public void ApplyInterest()
        {
            Balance *= (1 + interestRate);
        }
    }
}
