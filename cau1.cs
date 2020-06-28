using System;
using System.Collections.Generic;
using System.Text;

namespace onthiCC
{
    class cau1
    {
        public int BT1()
        {
            Console.WriteLine("CHAO MUNG CAC BAN DEN VOI MON HOC C++");
            return 1;
        }
        public int BT3()
        {
            float R;
            Console.WriteLine("Nhap ban kinh R:");
            R = Console.Read();
            double chuvi = 2 * R * 3.14;
            double dientich = R * R * 3.14;
            Console.WriteLine("Chu vi của hình tròn là:" + chuvi);
            Console.WriteLine("Dien tich của hình tròn là:" + dientich);
            return 0;
        }
        public int BT5()
        {
            float t;
            Console.WriteLine("Nhap t:");
            t =Console.Read();
            double y = Math.Pow(3 * Math.E, Math.Cos(t + 1));
            Console.WriteLine(y);
            return 0;
        }
        public int BT7()
        {
            String mssv, hoten, quequan, namsinh,dtb;
            Console.WriteLine("Nhap mssv:");
            mssv = Console.ReadLine();
            Console.WriteLine("Nhap hoten:");
            hoten = Console.ReadLine();
            Console.WriteLine("Nhap quequan:");
            quequan = Console.ReadLine();
            Console.WriteLine("Nhap namsinh:");
            namsinh = Console.ReadLine();
            Console.WriteLine("Nhap dtb:");
            dtb = Console.ReadLine();
            Console.WriteLine(mssv);
            Console.WriteLine(hoten);
            Console.WriteLine(quequan);
            Console.WriteLine(namsinh);
            Console.WriteLine(dtb);
            return 0;
        }
        public int BT09()
        {
            return 0; 
        }
        public int BT11()
        {
            int a, b, c;
            double delta, x1, x2;
            Console.WriteLine("phuong trinh bac 2");
            Console.WriteLine("Vui long nhap a:");
            a =int.Parse(Console.ReadLine());
            Console.WriteLine("Vui long nhap b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Vui long nhap c:");
            c =int.Parse(Console.ReadLine());
            delta = b * b - 4 * a * c;
            if (delta<0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else if (delta==0)
            {
                x1 = x2 = -b / 2 * a;
                Console.WriteLine("Phuong trinh co mot nghiem duy nhat" +x1);
            }
            else
            {
                Console.WriteLine("Phuong trinh co 2 nghiem phan biet");
                x1 = (-b+Math.Sqrt(delta))/2*a;
                Console.WriteLine("x1 =" + x1);
                x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine("x2 =" + x2);

            }
            return 0;
        }
        public int BT13()
        {
            int a;
            Console.WriteLine("Nhap a:");
            a =int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Day la so chan");
            }
            else
            {
                Console.WriteLine("Day la so le");
            }
            return 0;
        }
        public int BT15()
        {
            String ngchoi1 = "K";
            String ngchoi2 = "Bua";
            if (ngchoi1 =="K"&&ngchoi2=="Bua")
            {
                Console.WriteLine("Bua thang");
            }
            else if (ngchoi1 == "K" && ngchoi2 == "Bao")
            {
                Console.WriteLine("Keo thang");
            }
            else
            {
                Console.WriteLine("Bao thang");
            }

            return 0;
        }
        public int BT17()
        {
            int giobd, giokt, thoigian; 
            double tien;
            Console.WriteLine("Thoi gian bat dau:");
            giobd = int.Parse(Console.ReadLine());
            Console.WriteLine("Thoi gian ket thuc:");
            giokt = int.Parse(Console.ReadLine());
            thoigian = giokt - giobd;
            if (thoigian<=3)
            {
                tien = thoigian * 30000;
                Console.WriteLine("Tien phai tinh la" + tien);
            }else if (8 < thoigian)
            {
                tien = 3 * 30000 + 30000 * 0.7;
                Console.WriteLine("Tien phai tinh la" + tien);
            }
            else
            {
                tien = 3 * 30000 + 30000 * 0.9;
                Console.WriteLine("Tien phai tinh la" + tien);
            }
            return 0;
        }
        public int BT19()
        {
            //Viết chương trình nhập vào 3 số, tìm số lớn nhất, nhỏ nhất của 3 số đó. 
            int a, b, c;
            Console.WriteLine("Vui long nhap a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vui long nhap b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vui long nhap c:");
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("Vay a la so lon nhat");
                }
                else
                {
                    Console.WriteLine("Vay c la so lon nhat");

                }
            }
            else if (b>a)
            {
                if (b > c)
                {
                    Console.WriteLine("Vay b la so lon nhat");
                }
                else
                {
                    Console.WriteLine("Vay c la so lon nhat");

                }
            }
            else
            {
                Console.WriteLine("Vay c la so lon nhat");
            }
            return 0;
        }
        public int BT21()
        {
            //Viết chương trình xếp loại thi đua cho học sinh
            double diem;
            Console.WriteLine("Vui long nhap diem:");
            diem = double.Parse(Console.ReadLine());
            if (diem < 4)
            {
                Console.WriteLine("Day la hoc sinh yeu");
            }
            else if (diem < 6)
            {
                Console.WriteLine("Day la hoc sinh trung binh");
            }else if (diem<7)
            {
                Console.WriteLine("Day la hoc sinh kha");
            }
            else if (diem < 9)
            {
                Console.WriteLine("Day la hoc sinh gioi");
            }
            else if (diem <= 10)
            {
                Console.WriteLine("Day la hoc sinh xuat sac");
            }
            return 0;
        }
        public int BT23()
        {
            //Viết chương trình nhập vào 2 phân số, xuất ra tổng hiệu tích thương của hai phân số đó.Lưu ý kiểm tra điều kiện nhập mẫu khác 0(dùng do …while)
            double a, b,tong,hieu,tich,thuong;
            Console.WriteLine("Vui long nhap A:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Vui long nhap B:");
            b = double.Parse(Console.ReadLine());
            tong = a + b;
            hieu = a - b;
            tich = a * b;
            thuong = a / b;
            Console.WriteLine("Tong cua 2 phan so la:" + tong);
            Console.WriteLine("Hieu cua 2 phan so la:" + hieu);
            Console.WriteLine("tich cua 2 phan so la:" + tich);
            Console.WriteLine("Thuong cua 2 phan so la:" + thuong);

            return 0;
        }
        public int BT25()
        {
            double dientthu,tongtdien,tdien;
            Console.WriteLine("Nhap so luong dien tieu thu");
            dientthu = double.Parse(Console.ReadLine());
            if (dientthu <= 100)
            {
                tdien = 550 * dientthu;
            }
            else if (dientthu <= 150)
            {
                tdien = 550 * 100 + 900 * (dientthu - 100);
            }
            else if(dientthu<=200){
                tdien = 550 * 100 + 900 * 50 + 1250 * (dientthu - 150);
            }else if (dientthu<=300)
            {
                tdien = 550 * 100 + 900 * 50 + 1250 * 50 + 1450 * (dientthu - 200);
            }
            else
            {
                tdien = 550 * 100 + 900 * 50 + 1250 * 50 + 1450 * 100 + 1700 * (dientthu - 300);
            }
            tongtdien = tdien + tdien * 0.1;
            Console.WriteLine("So tien dien phai dong la:" + tongtdien);
            return 0;
        }
        public int BT27()
        {
            int so ;
            Console.WriteLine("Vui long nhap so co 2 chu so:");
            so = int.Parse(Console.ReadLine());
            if (10>so && so > 100)
            {
                Console.WriteLine("Vui long nhap so co 2 chu so");
            }
            else
            {
                int donvi = so % 10;
                int chuc = so / 10;
                if (chuc==2)
                {
                    Console.Write("Hai");
                }
                else if (chuc == 3)
                {
                    Console.Write("Ba");
                }else if (chuc == 4)
                {
                    Console.Write("Bon");
                }else if (chuc == 5)
                {
                    Console.Write("Nam");
                }else if (chuc == 6)
                {
                    Console.Write("Sau");
                }else if (chuc == 7)
                {
                    Console.Write("Bay");
                }else if (chuc == 8)
                {
                    Console.Write("Tam");
                }else if (chuc == 9)
                {
                    Console.Write("Chin");
                }
                else
                {
                    Console.Write("Muoi");
                }
                if (donvi ==1)
                {
                    Console.WriteLine(" Mot");
                }
                else if (donvi == 2)
                {
                    Console.WriteLine(" Hai");
                }
                else if (donvi == 3)
                {
                    Console.WriteLine(" Ba");
                }
                else if (donvi == 4)
                {
                    Console.WriteLine(" Bon");
                }
                else if (donvi == 5)
                {
                    Console.WriteLine(" Lam");
                }
                else if (donvi == 6)
                {
                    Console.WriteLine(" Sau");
                }
                else if (donvi == 7)
                {
                    Console.WriteLine(" Bay");
                }
                else if (donvi == 8)
                {
                    Console.WriteLine(" Tam");
                }
                else if (donvi == 9)
                {
                    Console.WriteLine(" Chin");
                }
            }
            return 0;
        }
        public int BT29()
        {
            return 0;
        }
        public int BT31()
        {
            int dem = 0;
            for(int i = 1; i<= 100; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    dem++;
                }
            }
            Console.WriteLine(dem);
            return 0;
        }
        public int BT33()
        {
            return 0;
        }
        public int BT35()
        {
            return 0;
        }
        public int BT37()
        {
            return 0;
        }
    }
}
