namespace BankingDomain;

public interface INotifyAccountReps
{
    void NotifyOfAttemptedOverdraft(BankAccount bankAccount, decimal balance, decimal amountToWithdraw);
}