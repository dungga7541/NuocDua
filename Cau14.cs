using System;
using System.Collections.Generic;
using System.Text;

namespace cau2
{
    class Cau14
    {
        public int BT14()
        {
            int a = 0, b = 0;
            Console.Write("Hay nhap a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Hay nhap b: ");
            b = int.Parse(Console.ReadLine());
            if (a > b)
                Console.WriteLine("So lon la: " + a);
            else
                Console.WriteLine("So lon la: " + b);
            return 0;
        }
    }
}
