namespace BankingDomain;

public enum BankAccountType { Standard, Gold };

public class BankAccount
{
    public BankAccountType AccountType = BankAccountType.Standard;
    private decimal _balance = 5000;
    public void Deposit(decimal amountToDeposit)
    {
        decimal bonus = AccountType == BankAccountType.Standard
            ? 0
            : amountToDeposit * .10M;

        _balance += amountToDeposit + bonus;
    }

    public decimal GetBalance()
    {
        return _balance; // BS, "SLIME"
    }

    public void Withdraw(decimal amountToWithdraw)
    {
        if (amountToWithdraw > _balance)
        {
            // TODO
            throw new OverdraftException();
        }
        else
        {
            _balance -= amountToWithdraw;
        }
    }
}