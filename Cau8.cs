using System;
using System.Collections.Generic;
using System.Text;

namespace cau2
{
    class Cau8
    {
        public int BT8()
        {
            double a = 0, b = 0, c = 0;
            Console.Write("Hay nhap a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Hay nhap b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Hay nhap b: ");
            c = double.Parse(Console.ReadLine());
            double chuvi = a + b + c;
            Console.WriteLine("Chu vi tam giac la: " + chuvi);
            double p = chuvi / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Dien tich tam giac la: " + S);
            return 0;
        }
    }
}
