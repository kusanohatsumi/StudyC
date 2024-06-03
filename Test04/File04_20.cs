using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test04
{
    internal class File04_20
    {
        //--- 問題の意味もよくわからなかった
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j <= i; j++)
                    Console.Write("$");

                Console.WriteLine();
            }
        }
        //---
    }
}
