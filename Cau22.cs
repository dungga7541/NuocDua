using System;
using System.Collections.Generic;
using System.Text;

namespace cau2
{
    class Cau22
    {
        public int BT22()
        {
            double a, b;
            Console.Write("Hay nhap a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Hay nhap b: ");
            b = double.Parse(Console.ReadLine());
            if (a != 0)
                Console.WriteLine("Nghiem cua pt: x = " + (-(b / a)));
            else if (a == 0 && b != 0)
                Console.WriteLine("PT vo nghiem");
            else
                Console.WriteLine("PT vo so nghiem");
            return 0;
        }
    }
}
