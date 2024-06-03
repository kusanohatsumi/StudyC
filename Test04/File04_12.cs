using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test04
{
    internal class File04_12
    {
        static void Main()
        {
            int sum = 0;

            while (sum <= 100)
                sum += int.Parse(Console.ReadLine());

            Console.WriteLine(sum);
        }
    }
}
