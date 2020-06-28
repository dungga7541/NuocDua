using System;
using System.Collections.Generic;
using System.Text;

namespace cau2
{
    class Cau30
    {
        public int BT30()
        {
            int n, S1 = 0, S2 = 0, S3 = 0;
             double S4=0;
            Console.WriteLine("Nhap n: ");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i<= n; i++)
            {
                S1 = S1 + i;
                Console.WriteLine("Tong tu 1 + 2 + 3 + .... + n la: " + S1);
            }
            for (int i = 0; i <= n; i++)
            {
                S2 = S2 + (2 * i + 1);
                Console.WriteLine("Tong tu 1 + 3 + 5 + .... + (2n + 1) la: " + S2);
            }
            int giaithua = 1;
            for(int i = 1; i<=n; i++)
            {
                for(int j = 1; j<= i; j++)
                    giaithua = giaithua * j;
                    S3 = S3 + giaithua;
                    Console.Write("Giai thua cua {0} la: {1}\n", n, giaithua);
            }
            for (int i = 2; i <= n; i++)
            {
                giaithua = giaithua * i ;
                S4 = S4 + (1.0 / giaithua);
                Console.WriteLine("Tong tu 1/2*3 + 1/3*4 + 1/4*5 + .... + 1/(n*(n + 1)) la: " + S4);
            }
            return 0;
        }
    }
}
