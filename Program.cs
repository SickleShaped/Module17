namespace Module17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var FirstAccount = new DefaultAccount();
            var SecondAccount = new BusinessAccount();

            Calculator.CalculateInterest(FirstAccount);
            Calculator.CalculateInterest(SecondAccount);
        }


    }
}
