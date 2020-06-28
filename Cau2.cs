using System;
using System.Collections.Generic;
using System.Text;

namespace cau2
{
    class Cau2
    {
        public int BT2()
        {
            int a;
            Console.Write("Hay nhap do dai cua canh: ");
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= a; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }
            return 0;
        }
    }
}
