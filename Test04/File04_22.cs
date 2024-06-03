using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test04
{
    internal class File04_22
    {
        static void Main()
        {
            int n1 = 0;
            int n2 = 1;
            int n3 = n1 + n2;

            while (n1 <= 1000)
            {
                Console.Write("{0},", n1);

                n1 = n2;
                n2 = n3;
                n3 = n1 + n2;
            }
        }
    }
}
