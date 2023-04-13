namespace Tap.Solid.Ocp
{
    public class BankAccount
    {
        public decimal AccountBalance { get; private set; }
        public AccountType AccountType { get; private set; }

        public BankAccount(decimal initialBalance, AccountType accountType)
        {
            AccountBalance = initialBalance;
            AccountType = accountType;
        }

        public class RegularCommissionCalculator 
    {
        public decimal CalculateCommission(decimal value)
        {
            return value * 0.04m;
        }
    }

    public class GoldCommissionCalculator 
    {
        public decimal CalculateCommission(decimal value)
        {
            return value * 0.02m;
        }
    }
    }
}
