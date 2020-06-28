using System;
using System.Collections.Generic;
using System.Text;

namespace cau2
{
    class Cau4
    {
        public int BT4()
        {
            double day1, day2, cao, S;
            Console.Write("Hay nhap day 1: ");
            day1 = double.Parse(Console.ReadLine());
            Console.Write("Hay nhap day 2: ");
            day2 = double.Parse(Console.ReadLine());
            Console.Write("Hay nhap cao: ");
            cao = double.Parse(Console.ReadLine());
            S = (day1 + day2) * cao / 2;
            Console.WriteLine("Dien tich hinh thang la: " + S);
            return 0;
        }
    }
}
