using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11_Proj2_AccountBalanceCalc
{
    internal interface Withdrawable
    {
        void Withdraw(decimal amount);  
    }
}
