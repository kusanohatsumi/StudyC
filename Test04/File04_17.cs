using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test04
{
    internal class File04_17
    {
        //--- 分からなかった
        static void Main()
        {
            for (int p = 1; p <= 9; p++)
            {
                for (int q = 1; q <= 9; q++)
                    Console.Write(" {0,2}", p * q);

                Console.WriteLine();
            }
        }
        //---
    }
}
