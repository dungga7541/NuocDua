using System;
using System.Collections.Generic;
using System.Text;

namespace cau2
{
    class Cau6
    {
        public int BT6()
        {
            int a = 0, b = 0;
            Console.Write("Hay nhap a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Hay nhap b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Tong cua hai so la: " + (a + b));
            Console.WriteLine("Hieu cua hai so la: " + (a - b));
            Console.WriteLine("Tich cua hai so la: " + (a * b));
            if(b != 0)
            {
                Console.WriteLine("Thuong cua hai so la: " + (a / b));
            }
            Console.WriteLine("Du cua hai so la: " + (a % b));
            if(a > b)
                Console.WriteLine("So lon la: " + a);
            else
                Console.WriteLine("So lon la: " + b);
            if (a < b)
                Console.WriteLine("So be la: " + a);
            else
                Console.WriteLine("So be la: " + b);
            return 0;
        }
    }
}
