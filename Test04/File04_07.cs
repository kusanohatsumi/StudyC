using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test04
{
    internal class File04_07
    {
        static void Main()
        {
            //--- 分からなかった
            int giants = 0;
            int tigers = 0;

            for (int game = 1; game <= 9; game++)
            {
                Console.Write(game + "回表、巨人の得点は？");
                giants += int.Parse(Console.ReadLine());

                Console.Write(game + "回裏、阪神の得点は？");
                tigers += int.Parse(Console.ReadLine());
            }

            Console.WriteLine("巨人：{0}点, 阪神：{1}点", giants, tigers);

            if (giants > tigers)
                Console.WriteLine("巨人の勝ち");
            else if (giants < tigers)
                Console.WriteLine("阪神の勝ち");
            else
                Console.WriteLine("引き分け");
            //---
        }

    }
}
