using System;
using System.Collections.Generic;
using System.Text;

namespace cau2
{
    class Cau28
    {
        public int BT28()
        {
            int N = 0;
            int tram = 0, chuc = 0, donvi = 0;
            tram = N / 100;
            donvi = N % 10;
            chuc = (N - tram * 100) / 10;
            Console.WriteLine("Hay nhap so nguyen 3 chu so: ");
            N = int.Parse(Console.ReadLine());
            string chuoi = "";
            switch (tram)
            {
                case 1: chuoi += "Mot tram";
                    break;
                case 2: chuoi += "Hai tram";
                    break;
                case 3:
                    chuoi += "Ba tram";
                    break;
                case 4:
                    chuoi += "Bon tram";
                    break;
            }
            switch (chuc)
            {
                case 1:
                    chuoi += "Mot chuc";
                    break;
                case 2:
                    chuoi += "Hai chuc";
                    break;
                case 3:
                    chuoi += "Ba chuc";
                    break;
                case 4:
                    chuoi += "Bon chuc";
                    break;
            }
            switch (donvi)
            {
                case 1:
                    chuoi += "Mot dv";
                    break;
                case 2:
                    chuoi += "Hai dv";
                    break;
                case 3:
                    chuoi += "Ba dv";
                    break;
                case 4:
                    chuoi += "Bon dv";
                    break;
            }
            return 0;
        }
    }
}
