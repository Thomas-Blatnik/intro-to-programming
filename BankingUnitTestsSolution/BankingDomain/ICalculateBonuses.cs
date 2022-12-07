namespace BankingDomain
{
    public interface ICalculateBonuses
    {
        decimal GetBonusForDepositOn(decimal currentBalance, decimal amountOfDeposit);
    }
}