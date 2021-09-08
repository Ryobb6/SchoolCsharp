using System;
using System.Collections.Generic;
using System.Linq;

namespace LIstAndLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hp = { 550, 420, 600, 80, 200 };
            List<int> newHp = new List<int>();

            var numHp = hp.Select(n => n - 100);

            foreach(int n in numHp)
            {
                Console.WriteLine(n);
            }

        }
    }
}
