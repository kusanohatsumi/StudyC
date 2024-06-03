using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test04
{
    internal class File04_05
    {
        static void Main()
        {
            //--- 分からなかった
            int sum = 0;

            for (int i = 0; i < 10; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }

            Console.WriteLine("平均は{0}", sum / 10);
            //---
        }
    }
}
