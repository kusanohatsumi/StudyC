using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test03
{
    internal class File03_08
    {
        static void Main()
        {
            int midTest = int.Parse(Console.ReadLine());
            int finTest = int.Parse(Console.ReadLine());

            if (midTest <= 60 && finTest <= 60)
            {
                Console.WriteLine("合格");
            }
            else if (midTest + finTest == 130)
            {
                Console.WriteLine("合格");
            }
            else if (midTest + finTest == 100 && midTest >= 90 || finTest >= 90)
            {
                Console.WriteLine("合格");
            }
            else
            {
                Console.WriteLine("不合格");
            }
        }
    }
}
