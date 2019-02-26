using System;

namespace Bank_Account
{
    class SavingsAccount
    {
        Double annualInterestRate = 0;
        private Double savingsBalance;
        private Double newBalance = 0;
        Double interestRate = 0;

        public SavingsAccount(Double savingsBalance)
        {
            Double CalculateMonthlyInterest()
            {
                newBalance = (savingsBalance * annualInterestRate) / 12;

                return newBalance;
            }// end CalculateMonthlyInterestRate

            Double ModifyInterestRate(Double interestRate)
            {
                annualInterestRate = interestRate;

                return annualInterestRate;
            }// end ModifyInterestRate
        }
    }
}
    
