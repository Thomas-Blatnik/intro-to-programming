﻿namespace BankingDomain;

public class BankAccount
{
    private decimal _balance = 5000;
    public virtual void Deposit(decimal amountToDeposit)
    {
        _balance += amountToDeposit;
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