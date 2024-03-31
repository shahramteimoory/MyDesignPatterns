using StrategyPattern.Example2.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Example2
{
    public class UserByBalance : IComparer<User>
    {
        public int Compare(User? x, User? y)
        {
            if (x.Balance==y.Balance)
                return 0;
            else if (x.Balance < y.Balance)
                return -1;
            else 
                return 1;
        }
    }
}
