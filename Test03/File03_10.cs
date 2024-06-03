using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test03
{
    internal class File03_10
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if(x == y && (x % 2 == 0 && y % 2 == 0))
            {
                Console.WriteLine("xはyより小さく、かつ、xとyは共に偶数である。");
            }

            if((x == y) && (x < 0))
            {
                Console.WriteLine("xとyは等しく、かつ、負の数である。");
            }

            if ((x <= y) && x % 2 == 0)
            {
                Console.WriteLine("xはyより小さい、または、xは偶数である。");
            }

            if(( x  <= 10 || x >= 100 ) && ( y <= 10 && y <= 100 ) )
            {
                Console.WriteLine("xは10以下または100以上で、かつ、yは10以上かつ100以下である。");
            }

            if (!(x < 0 && y < 0))
            {
                Console.WriteLine("xもyも負の数である、ではない。");
            }

        }
    }
}
