using System;
using Xunit;
using static lab_02_unit_tests.Program;

namespace ATMTests
{
    public class UnitTest1
    {
        [Fact]
        public void WithdrawMoney()
        {
            decimal balance = lab_02_unit_tests.Program.currentBalance;
            Assert.Equal(currentBalance-500, Withdraw(500));
        }

        [Fact]
        public void WithdrawMoney2()
        {
            decimal balance = lab_02_unit_tests.Program.currentBalance;
            Assert.Equal(currentBalance-1000, Withdraw(1000));
        }
    }
}
