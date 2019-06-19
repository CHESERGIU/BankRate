using System;
using Xunit;

namespace BankRate.Tests
{
    public class BankRateTests
    {
        [Fact]
        public void CalculateRateForFirstMonth()
        {
            var rate = new Money();
            var actual = rate.CalculateBankRate(200, 2, 12, 1);
            Assert.Equal(102, actual);
        }

        [Fact]
        public void CalculateRateForSecondMonth()
        {
            var rate = new Money();
            var actual = rate.CalculateBankRate(200, 2, 12, 2);
            Assert.Equal(101, actual);
        }

        [Fact]
        public void CalculateRateForThirdMonthForATenMonthCredit()
        {
            var rate = new Money();
            var actual = rate.CalculateBankRate(2000, 10, 12, 3);
            Assert.Equal(216, actual);
        }
    }
}
