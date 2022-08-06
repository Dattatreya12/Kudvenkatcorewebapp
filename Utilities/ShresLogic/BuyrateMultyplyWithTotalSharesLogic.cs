using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Utilities.ShresLogic
{
    public class BuyrateMultyplyWithTotalSharesLogic : BuyrateMultyplyWithTotalShares
    {
        public override double TotalInvestedAmountinShares(double a, double b)
        {
            double c;
            c = a * b;
            return c;
        }

        
        public override double TotalIntrest(double a, double b)
        {
            double c;
            //b = 1;
            c = a * b/100;
            return c;
        }
    }
}
