﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11_Proj2_AccountBalanceCalc
{
    public abstract class Account : Depositable, Withdrawable, Balanceable
    {
        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
    }
}
