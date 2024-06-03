using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test04
{
    internal class File04_09
    {
        static void Main()
        {
            //--- 分からなかった
            int max_num = 0, min_num = 0;

            for (int i = 0; i < 10; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    max_num = num;
                    min_num = num;
                }
                else
                {
                    if (num > max_num)
                        max_num = num;

                    if (num < min_num)
                        min_num = num;
                }
            }

            Console.WriteLine("最大値={0} 最小値={1}", max_num, min_num);
        }
    }
}
