using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test04
{
    internal class File04_06
    {
        static void Main()
        {
            //--- 分からなかった
            int wins = 0;

            for (int i = 0; i < 10; i++)
            {
                int result = int.Parse(Console.ReadLine());

                if (result == 1)
                    wins += 1;
            }

            Console.WriteLine("勝ち{0}回、負け{1}回", wins, 10 - wins);
            //--- 
        }
    }
}
