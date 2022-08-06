using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Helpers
{
    public class GenericsLogic
    {
        public static double Add<T>(double val1, double val2)
        {
            return val1 + val2;
        }

        public static double Sub<T>(double val1, double val2)
        {
            return val1 - val2;
        }

    }
}
