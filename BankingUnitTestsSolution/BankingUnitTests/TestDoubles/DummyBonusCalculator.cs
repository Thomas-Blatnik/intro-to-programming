
namespace BankingUnitTests.TestDoubles
{
    internal class DummyBonusCalculator : ICalculateBonuses
    {
        public decimal GetBonusForDepositOn(decimal currentBalance, decimal amountOfDeposit)
        {
            return 0;
        }
    }
}
