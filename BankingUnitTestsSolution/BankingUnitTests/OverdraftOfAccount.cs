using BankingUnitTests.TestDoubles;

namespace BankingUnitTests;

public class OverdraftOfAccount
{
    [Fact] // Safety Net - and "Invariant"
    public void CanTakeAllTheMoney()
    {
        var account = new BankAccount(new DummyBonusCalculator());

        account.Withdraw(account.GetBalance());

        Assert.Equal(0, account.GetBalance());
    }

    [Fact]
    public void OverdraftDoesNotDecreaseTheBalance()
    {
        var account = new BankAccount(new DummyBonusCalculator());
        var openingBalance = account.GetBalance();
        var amountToWithdraw = openingBalance + 0.01M;

        // Exceptional Behavior
        try
        {
            account.Withdraw(amountToWithdraw);
        }
        catch (OverdraftException)
        {

            // Ignore it
        }

        Assert.Equal(openingBalance, account.GetBalance());
    }

    [Fact]
    public void OverdraftThrowsAnOverdraftException()
    {
        var account = new BankAccount(new DummyBonusCalculator());

        Assert.Throws<OverdraftException>(() =>
        {
            account.Withdraw(account.GetBalance() + 0.01M);
        });
    }
}
