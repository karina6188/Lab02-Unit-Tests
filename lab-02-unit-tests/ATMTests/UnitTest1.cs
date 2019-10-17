using System;
using Xunit;
using static lab_02_unit_tests.Program;

namespace ATMTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Test on withdrawing money within the current balance amount.
        /// </summary>
        [Fact]
        public void WithdrawMoney()
        {
            decimal balance = lab_02_unit_tests.Program.currentBalance;
            Assert.Equal(currentBalance-500, Withdraw(500));
        }

        /// <summary>
        /// If withdraw more than the current balance, the transaction is not processed.
        /// The current balance remain unchanged.
        /// </summary>
        [Fact]
        public void WithdrawMoneyMoreThanBalance()
        {
            decimal balance = lab_02_unit_tests.Program.currentBalance;
            Assert.Equal(currentBalance, Withdraw(90000));
        }

        /// <summary>
        /// If deposit is greater than 0, the transaction is processed.
        /// The current balance is changed to add the deposit amount.
        /// </summary>
        [Fact]
        public void DepositMoney()
        {
            decimal balance = lab_02_unit_tests.Program.currentBalance;
            Assert.Equal(currentBalance+253, Deposit(253));
        }

        /// <summary>
        /// If deposit a negative amount to the account, the transaction is not processed.
        /// The current balance remain unchanged.
        /// </summary>
        [Fact]
        public void DepositNegative()
        {
            decimal balance = lab_02_unit_tests.Program.currentBalance;
            Assert.Equal(currentBalance, Deposit(-9782));
        }
    }
}
