using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test04
{
    internal class File04_14
    {
        static void Main()
        {
            //--- 分からなかった
            int strike = 0;
            int ball = 0;

            while (strike < 3 && ball < 4)
            {
                Console.Write("ストライク=1 or ボール=2 or ファウル=3？");

                int judge = int.Parse(Console.ReadLine());

                if (judge == 1)
                    strike++;
                else if (judge == 2)
                    ball++;
                else if (judge == 3 && strike < 2)
                    strike++;
            }

            Console.WriteLine("{0}ボール,{1}ストライク", ball, strike);
            //---
        }
    }
}
