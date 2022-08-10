using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectProject
{
    public class TaxCalculate : ITaxCalculator
    {
        private readonly decimal _rate;
        public TaxCalculate(decimal rate)
        {
            _rate = rate;
        }

        public decimal CalculateTax(decimal gross)
        {
           return Math.Round(_rate * gross);
        }
    }
}
