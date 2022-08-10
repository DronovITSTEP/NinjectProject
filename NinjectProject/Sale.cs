using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectProject
{
    public class Sale
    {
        private readonly ITaxCalculator _taxCalculator;

        public Sale(ITaxCalculator taxCalculator)
        {
            _taxCalculator = taxCalculator;
        }
        public void GetTotal() { }
    }
}
