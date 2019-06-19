using System;

namespace BankRate
{
    public class Program
    {
        public static void Main(string[] args)
        {            
        }

        public static decimal CalculateBankRate(decimal total, int periodInMonth, decimal interestPerYear, int currentMonth)
        {
            decimal principal = total / periodInMonth;
            decimal exactInterestPerMonth = interestPerYear / 12 / 100;
            return principal + total * exactInterestPerMonth;
        }
    }
}
