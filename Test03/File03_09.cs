﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test03
{
    internal class File03_09
    {
        static void Main()
        {
            //--- ↓分からなかった
            Console.WriteLine("曜日を選択してください");
            Console.Write("0=日曜、1=月曜、2=火曜、3=水曜、4=木曜、5=金曜、6=土曜");
            int day = int.Parse(Console.ReadLine());

            Console.WriteLine("時間帯を選択してください");
            Console.Write("0=午前、1=午後、2=夜間");
            int zone = int.Parse(Console.ReadLine());

            bool bopen = true;

            if (day == 0)
                bopen = false;
            else if (zone == 0 && (day == 2 || day == 5))
                bopen = false;
            else if (zone == 1 && day == 6)
                bopen = false;
            else if (zone == 2 && (day == 3 || day == 6))
                bopen = false;

            if (bopen)
                Console.WriteLine("診療しています。");
            else
                Console.WriteLine("休診です。");
            //--- 
        }
    }
}
