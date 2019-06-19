using System;
using Xunit;

namespace BankRate.Tests
{
    public class BankRateTests
    {
        [Fact]
        public void CalculateRateForFirstMonth()
        {
            decimal rate = Program.CalculateBankRate(200, 2, 12, 1);
            Assert.Equal(102, rate);
        }

        [Fact]
        public void CalculateRateForSecondMonth()
        {
            decimal rate = Program.CalculateBankRate(200, 2, 12, 2);
            Assert.Equal(101, rate);
        }

        [Fact]
        public void CalculateRateForThirdMonthForATenMonthCredit()
        {
            decimal rate = Program.CalculateBankRate(2000, 10, 12, 3);
            Assert.Equal(216, rate);
        }
    }
}
