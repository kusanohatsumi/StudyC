using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test03
{
    internal class File03_12
    {
        static void Main()
        {
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("何月？");

            switch (month)
            {
                case 2 :
                    Console.WriteLine("28日");
                    break;
                case 1:
                case 3:
                case 5: 
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("31日");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("30日");
                    break;

            }
        }
    }
}
