using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11_Proj2_AccountBalanceCalc
{
    internal class CheckingAccount : Account
    {
        public decimal MonthlyFee { get; set; }
        public CheckingAccount(decimal MonthlyFee)
        {
            this.MonthlyFee = MonthlyFee;
        }
        public void SubtractFeeFromBalance()
        {
            Balance -= MonthlyFee;
        }

    }

 }

