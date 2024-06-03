using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test04
{
    internal class File04_19
    {
        static void Main()
        {
            int sum = 0;
            int count = 0;

            for (; ; )
            {
                int num = int.Parse(Console.ReadLine());

                if (num == 0)
                    break;

                count++;
                sum += num;
            }

            Console.WriteLine(sum / count);
        }
    }
}
