using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test03
{
    internal class File03_07
    {
        static void Main()
        {
            Case1();
            Case2();
            Case3();
        }

        static void Case1()
        {
            // ケース１
            int score = int.Parse(Console.ReadLine());

            if (score >= 60)
                Console.WriteLine("合格");
            else
                Console.WriteLine("不合格");

        }

        static void Case2()
        {
            // ケース２
            int score = int.Parse(Console.ReadLine());

            if (score >= 80)
                Console.WriteLine("たいへんよくできました。");
            else if (score >= 60)
                Console.WriteLine("よくできました。");
            else
                Console.WriteLine("ざんねんでした。");
        }

        static void Case3()
        {
            // ケース３
            int score = int.Parse(Console.ReadLine());

            if (score >= 80)
                Console.WriteLine("優");
            else if (score >= 70)
                Console.WriteLine("良");
            else if (score >= 60)
                Console.WriteLine("可");
            else
                Console.WriteLine("不可");
        }
    }
}
