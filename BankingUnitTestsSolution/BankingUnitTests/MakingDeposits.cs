using BankingUnitTests.TestDoubles;

namespace BankingUnitTests;

public class MakingDeposits
{
    [Theory]
    [InlineData(100)]
    [InlineData(50)]
    public void MakingDepositsIncreasesBalance(decimal amountToDeposit)
    {
        // Given
        var account = new BankAccount(new Mock<ICalculateBonuses>().Object, new Mock<INotifyAccountReps>().Object);
        var openingBalance = account.GetBalance();
       
        // When
        account.Deposit(amountToDeposit);

        // Then
        Assert.Equal(amountToDeposit + openingBalance, account.GetBalance());
    }
}
