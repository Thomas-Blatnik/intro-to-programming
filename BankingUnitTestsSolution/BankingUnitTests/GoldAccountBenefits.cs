

namespace BankingUnitTests;

public class GoldAccountBenefits
{
    [Fact]
    public void GetBonusOnDeposit()
    {
        // Given (Context)
        var account = new BankAccount();
        account.AccountType = BankAccountType.Gold;
        var openingBalance = account.GetBalance();
        var amountToDeposit = 100M;
        var expectedBonus = 10M;

        // When
        account.Deposit(amountToDeposit);

        // Then
        Assert.Equal(openingBalance + amountToDeposit + expectedBonus, account.GetBalance());
    }
}
