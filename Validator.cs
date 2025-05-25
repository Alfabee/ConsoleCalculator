using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Validator : IValidator
    {
        public bool IsValidDivision(int denominator)
        {
            return denominator != 0;
        }
    }
}
