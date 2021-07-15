using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevopsPractice.Services
{
    public class Calculator
    {
        public bool Add(int a, int b, out double? result)
        {
            if(a < 0 || b < 0)
            {
                result = null;
                return false;
            }
            result = a + b;
            return true;
        }
    }
}
