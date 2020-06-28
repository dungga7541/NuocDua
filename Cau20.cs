using System;
using System.Collections.Generic;
using System.Text;

namespace cau2
{
    class Cau20
    {
        public int BT20()
        {
            int a = 0, b = 0, c = 0, d = 0;
            Console.Write("Hay nhap a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Hay nhap b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Hay nhap c: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Hay nhap d: ");
            d = int.Parse(Console.ReadLine());
            //So lon nhat
            if (a > b && a > c && a > d)
                Console.WriteLine("So lon nhat la: " + a);
            else if (b > a && b > c && b > d)
                Console.WriteLine("So lon nhat la: " + b);
            else if (c > a && c > b && c > d)
                Console.WriteLine("So lon nhat la: " + c);
            else
                Console.WriteLine("So lon nhat la: " + d);
            //So nho nhat
            if (a < b && a < c && a < d)
                Console.WriteLine("So nho nhat la: " + a);
            else if (b < a && b < c && b < d)
                Console.WriteLine("So nho nhat la: " + b);
            else if (c < a && c < b && c < d)
                Console.WriteLine("So nho nhat la: " + c);
            else
                Console.WriteLine("So nho nhat la: " + d);
            return 0;
        }
    }
}
