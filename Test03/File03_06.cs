using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test03
{
    internal class File03_06
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            if( num % 2 == 0)
            {
                if ( num >= 0)
                {
                    Console.WriteLine("正の偶数");
                }
                else
                {
                    Console.WriteLine("負の偶数");
                }
            }
            else
            {
                if( num >= 0)
                {
                    Console.WriteLine("正の奇数");
                }
                else
                {
                    Console.WriteLine("負の奇数");
                }
            }

        }
    }
}
