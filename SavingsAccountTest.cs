using System;
using static Bank_Account.SavingsAccount;


namespace Bank_Account
{
    class SavingsAccountTest
    {
        static void Main(string[] args)
        {
            SavingsAccount saver1 = new SavingsAccount(2000.00);
            SavingsAccount saver2 = new SavingsAccount(3000.00);
            Double newInterestRate;
            Double saver1Balances;
            Double saver2Balances;

            newInterestRate = ModifyInterestRate(0.04);
            saver1Balances = saver1.CalculateMonthlyInterest();
            saver2Balances = saver2.CalculateMonthlyInterest();
            Console.WriteLine("Savings account saver1 balance is now: ", saver1Balance);

            saver2Balance = saver2.ModifyInterestRate(0.05);

        }

       
    }
}
