using System;
using Xunit;
using static lab_02_unit_tests.Program;

namespace ATMTests
{
    public class UnitTest1
    {
        [Fact]
        public void WithdrawMoreThanBalance()
        {
            decimal amount = Withdraw("500");
            Assert.Equal(11500, amount);
        }
    }
}
