namespace BankRate
{
    public class Money
    {
        private readonly decimal principal;
        private readonly decimal total;
        private readonly decimal interestPerYear;
        private readonly decimal exactInterestPerMonth;
        private readonly decimal sold;
        private readonly int periodInMonth;
        private readonly int currentMonth;

        public decimal CalculateBankRate(decimal total, int periodInMonth, decimal interestPerYear, int currentMonth)
        {
            decimal principal = total / periodInMonth;
            decimal exactInterestPerMonth = interestPerYear / 12 / 100;
            decimal sold = total - ((currentMonth - 1) * principal);
            return principal + (sold * exactInterestPerMonth);
        }
    }
}
