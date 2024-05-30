using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01
{
    class Practice1_7
    {
        static void Main()
        {
            int x = 3;
            int y = 4;

            //--- ↓分からなかった
            int t = x;
            x = y;
            y = t;
            //---

            Console.WriteLine("x={0},y={1}", x, y);
        }
    }
}
