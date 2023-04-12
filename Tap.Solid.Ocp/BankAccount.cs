namespace Tap.Solid.Ocp
{
    public interface ICommissionCalculator
   {
       decimal CalculateCommission(decimal value);
    }

    public class RegularCommissionCalculator :ICommissionCalculator
    {
        public decimal CalculateCommission(decimal value)
        {
            return value * 0.04m;
        }
    }

    public class GoldCommissionCalculator : ICommissionCalculator
    {
        public decimal CalculateCommission(decimal value)
        {
            return value * 0.02m;
        }
    }

    public class BankAccount
    {
        public decimal AccountBalance { get; private set; }
        public AccountType AccountType { get; private set; }

        public BankAccount(decimal initialBalance, AccountType accountType)
        {
            AccountBalance = initialBalance;
            AccountType = accountType;
        }

        public void ExtractMoney(decimal value,ICommissionCalculator commissionCalculator)
        {
            var commission = commissionCalculator.CalculateCommission(value);
            AccountBalance = AccountBalance - (value + commission);
        }
    }
}