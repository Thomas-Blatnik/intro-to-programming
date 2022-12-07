namespace BankingDomain
{
    public class StandardBonusCalculator : ICalculateBonuses
    {
        public StandardBonusCalculator()
        {
        }

        public decimal GetBonusForDepositOn(decimal currentBalance, decimal amountOfDeposit)
        {
            return currentBalance >= 5000 ? amountOfDeposit * .10M : 0;
        }
    }
}