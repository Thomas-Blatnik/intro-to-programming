
namespace BankingUnitTests.TestDoubles;

// Canned responses to questions.
internal class StubbedBonusCalculator : ICalculateBonuses
{
    public decimal GetBonusForDepositOn(decimal currentBalance, decimal amountOfDeposit)
    {
        return currentBalance == 5000M && amountOfDeposit == 92.42M ? 42 : 0;
    }
}
