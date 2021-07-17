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

        public bool Subtract(int a, int b, out double? result)
        {
            result = null;
            if(a < 0 || b < 0)
            {
                return false;
            }

            if(a < b)
            {
                return false;
            }

            result = a - b;
            return true;
        }

        public bool Multiply(int a, int b, out double? result)
        {
            result = null;
            if(a < 0 || b < 0)
            {
                return false;
            }

            result = a * b;
            return true;
        }

        public bool Divide(int a, int b, out double? result)
        {
            result = null;
            if(a < 0 || b <= 0)
            {
                return false;
            }
            result = (double)a / (double)b;
            return true;
        }
    }
}
