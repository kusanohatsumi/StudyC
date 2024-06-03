using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test04
{
    internal class File04_18
    {
        static void Main()
        {
            //--- 分からなかった
            int sum = 0;

            for (; ; )    // while (true) でもよい。
            {
                int num = int.Parse(Console.ReadLine());

                if (num == 0)
                    break;

                sum += num;
            }

            Console.WriteLine("合計は" + sum);
            //---
        }
    }
}
