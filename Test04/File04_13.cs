using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test04
{
    internal class File04_13
    {
        static void Main()
        {
            //--- 分からなかった
            int strike = 0;
            int ball = 0;

            while (strike < 3 && ball < 4)
            {
                Console.Write("ストライク=1 or ボール=2 ？");

                int judge = int.Parse(Console.ReadLine());

                if (judge == 1)
                    strike++;
                else if (judge == 2)
                    ball++;
            }

            Console.WriteLine("{0}ボール,{1}ストライク", ball, strike);
            //---
        }
    }
}
