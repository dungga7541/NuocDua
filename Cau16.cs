using System;
using System.Collections.Generic;
using System.Text;

namespace cau2
{
    class Cau16
    {
        public int BT16()
        {
            double TNCT = 0, heso = 0, luong = 0;
            int luongcanban = 650000;
            Console.Write("Hay nhap tham nien cong tac: ");
            TNCT = double.Parse(Console.ReadLine());
            if (TNCT < 12)
                heso = 1.92;
            else if (TNCT < 36)
                heso = 2.34;
            else if (TNCT < 60)
                heso = 3;
            else
                heso = 4.5;
            luong = heso * luongcanban;
            Console.WriteLine("Luong la: " + luong);
            return 0;
        }
    }
}
