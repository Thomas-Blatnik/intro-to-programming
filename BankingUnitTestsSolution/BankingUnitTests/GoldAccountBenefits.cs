using BankingUnitTests.TestDoubles;

namespace BankingUnitTests;

public class GoldAccountBenefits
{
    [Fact]
    public void GetBonusOnDeposit()
    {
        // Given (Context)
        var stubbedBonusCalculator = new Mock<ICalculateBonuses>();
        var account = new BankAccount(new StubbedBonusCalculator());
        var openingBalance = account.GetBalance();
        var amountToDeposit = 92.42M;
        var expectedBonus = 42M;
        stubbedBonusCalculator.Setup(s => s.GetBonusForDepositOn(openingBalance, amountToDeposit)).Returns(expectedBonus);

        // When
        account.Deposit(amountToDeposit);

        // Then
        Assert.Equal(openingBalance + amountToDeposit + expectedBonus, account.GetBalance());
    }
}
