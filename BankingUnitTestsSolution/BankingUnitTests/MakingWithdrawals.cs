using BankingUnitTests.TestDoubles;

namespace BankingUnitTests
{
    public class MakingWithdrawals
    {
        [Theory]
        [InlineData(100)]
        [InlineData(50)]
        public void MakingWithdrwalsDecreasesBalance(decimal amountToWithdraw)
        {
            // Given
            var account = new BankAccount(new DummyBonusCalculator(), new Mock<INotifyAccountReps>().Object);
            var openingBalance = account.GetBalance();

            // When
            account.Withdraw(amountToWithdraw);

            // Then
            Assert.Equal(openingBalance - amountToWithdraw, account.GetBalance());
        }
    }
}
