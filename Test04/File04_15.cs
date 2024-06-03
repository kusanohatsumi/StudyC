using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test04
{
    internal class File04_15
    {
        static void Main()
        {
            //--- C#での因数分解が分からなかった
            int n = int.Parse(Console.ReadLine());

            for (int x = 2; n > 1; x++)
            {
                while ((n % x) == 0)
                {
                    Console.Write("{0} ", x);
                    n /= x;
                }
            }
            //---
        }
    }
}
