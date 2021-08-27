using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example
{
   static class Class1
    {
        public static int ReturnNum()
        {
            int[] hp = { -1, -10, -5, -40, -15 };

            int num = hp.Select(n => n + 10).Where(n => n >= 0).Count();

            return num;

        }

    }
}
