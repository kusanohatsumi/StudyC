using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test03
{
    internal class File03_11
    {
        static void Main()
        {
            Console.WriteLine("好きな鮨を選択してください");
            Console.Write("1：まぐろ, 2：えび, 3：こはだ");

            int fish = int.Parse(Console.ReadLine());
            switch (fish)
            {
                case 1:
                    Console.WriteLine("大吉");
                    break;
                case 2:
                    Console.WriteLine("小吉");
                    break;
                case 3:
                    Console.WriteLine("中吉");
                    break;
            }
        }
    }
}
