using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace NinjectProject
{
    public class Sale3
    {
        [Inject]
        public ITaxCalculator taxCalculator { get; set; }

        public decimal GetTotal()
        {
            decimal total = 0;
            foreach (var item in lineItems)
            {
                total += taxCalculator.CalculateTax(item);
            }
            return total;
        }
    }
}
