using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11_Proj2_AccountBalanceCalc
{
    internal class SavingsAccount : Account
    {
        public decimal MonthlyInterestRate {  get; set; }
        public decimal MonthylInterestPayment { get; set; }

        public SavingsAccount(decimal monthlyInterestRate)
        {
            MonthlyInterestRate = monthlyInterestRate;
        }

        public void ApplyInterestPayment()
        {
            MonthylInterestPayment = Balance * MonthlyInterestRate;
            Balance += MonthylInterestPayment;
        }
    }
}
