using System;
using System.Collections.Generic;
using System.Text;

namespace cau2
{
    class Cau10
    {
        public int BT10()
        {
            double xA = 0, xB = 0, xC = 0, yA=0, yB = 0, yC = 0, x1 = 0, x2 = 0;
            Console.Write("Hay nhap xA: ");
            xA = double.Parse(Console.ReadLine());
            Console.Write("Hay nhap yA: ");
            yA = double.Parse(Console.ReadLine());
            Console.Write("Hay nhap xB: ");
            xB = double.Parse(Console.ReadLine());
            Console.Write("Hay nhap yB: ");
            yB = double.Parse(Console.ReadLine());
            Console.Write("Hay nhap xC: ");
            xC = double.Parse(Console.ReadLine());
            Console.Write("Hay nhap yC: ");
            yC = double.Parse(Console.ReadLine());
            x1 = (xA + xB + xC) / 3;
            x2 = (yA + yB + yC) / 3;
            Console.WriteLine("Trong tam I la: " + (x1, x2));
            return 0;
        }
    }
}
