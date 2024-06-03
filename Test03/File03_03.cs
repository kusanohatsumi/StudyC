using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test03
{
    internal class File03_03
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if ( x > y )
            {
                Console.WriteLine("xはyより大きい");
            } else if ( x < y )
            {
                Console.WriteLine("xはyより小さい");
            }
        }
    }
}
