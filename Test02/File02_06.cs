using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test02
{
    internal class File02_06
    {
        static void Main()
        {
            //--- ↓分からなかった
            Console.WriteLine("あなたの年齢は？");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("生まれてから今まで、およそ {0}日です", age * 365);
            //---
        }
    }
}
