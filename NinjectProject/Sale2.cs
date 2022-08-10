using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace NinjectProject
{
    public class Sale2
    {
        private ITaxCalculator _taxCalculator;
        public Sale2() { }

        [Inject]
        public Sale2(ITaxCalculator taxCalculator)
        {
            _taxCalculator = taxCalculator;
        }
    }
}
