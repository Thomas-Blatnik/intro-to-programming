namespace BankingDomain;

public class BankAccount
{
    private readonly ICalculateBonuses _calculator;
    private readonly INotifyAccountReps _accountRepNotifier;
    private decimal _balance = 5000;

    public BankAccount(ICalculateBonuses calculator, INotifyAccountReps accountRepNotifier)
    {
        _calculator = calculator;
        _accountRepNotifier = accountRepNotifier;
    }

    public void Deposit(decimal amountToDeposit)
    {
        var bonus = _calculator.GetBonusForDepositOn(_balance, amountToDeposit);
        _balance += amountToDeposit + bonus;
    }

    public decimal GetBalance()
    {
        return _balance; 
    }

    public void Withdraw(decimal amountToWithdraw)
    {
        if (amountToWithdraw > _balance)
        {
            // TODO
            _accountRepNotifier.NotifyOfAttemptedOverdraft(this, _balance, amountToWithdraw);
            throw new OverdraftException();
        }
        else
        {
            _balance -= amountToWithdraw;
        }
    }
}