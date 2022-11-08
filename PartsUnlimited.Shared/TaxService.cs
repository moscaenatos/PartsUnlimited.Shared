using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsUnlimited.Shared
{
    public class TaxService
    {
        static public decimal CalculateTax(decimal taxable, string postalCode)
        {   if (postalCode == null)
                return (decimal)0.1;
            return taxable * (decimal).1;
        }
    }
}
