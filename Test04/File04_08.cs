using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test04
{
    internal class File04_08
    {
        static void Main()
        {
            //--- 分からなかった
            int max_num = 0;

            for (int i = 0; i < 10; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num > max_num)
                    max_num = num;
            }

            Console.WriteLine("最大値=" + max_num);
            //---
        }
    }
}
