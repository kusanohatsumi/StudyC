using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test04
{
    internal class File04_21
    {
        //--- 分からなかった
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j || (size - i - 1) == j)
                        Console.Write("X");
                    else
                        Console.Write(" ");
                }

                Console.WriteLine();
            }
        }
        //--- 分からなかった
    }
}
