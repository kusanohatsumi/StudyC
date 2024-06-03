using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test04
{
    internal class File04_16
    {
        static void Main()
        {
            //--- 分からなかった
            int num = int.Parse(Console.ReadLine());
            int n;

            for (n = 2; n <= (num / 2); n++)
            {
                if ((num % n) == 0)
                    break;
            }

            if (n > (num / 2))
                Console.WriteLine("{0}は素数です", num);
            else
                Console.WriteLine("{0}は素数ではありません", num);
            //---
        }
    }
}
