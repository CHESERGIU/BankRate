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
    }
}
