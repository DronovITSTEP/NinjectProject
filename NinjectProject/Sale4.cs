using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace NinjectProject
{
    public class Sale4
    {
        private ITaxCalculator _taxCalculator;

        [Inject]
        public void SetTaxCalc(ITaxCalculator taxCalculator)
        {
            _taxCalculator = taxCalculator;
        }
        public decimal GetTotal()
        {
            decimal total = 0;
            foreach (var item in listItems)
            {
                total += _taxCalculator.CalculateTax(item);
            }
            return total;
        }
    }
}
