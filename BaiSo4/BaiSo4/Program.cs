using System;

namespace BaiSo4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a115, b115, c115;
            Console.WriteLine("Nhap 3 so : ");
            a115 = Convert.ToDouble(Console.ReadLine());
            b115 = Convert.ToDouble(Console.ReadLine());
            c115 = Convert.ToDouble(Console.ReadLine());

            if (a115 + b115 > c115 && a115 + c115 > b115 && b115 + c115 > a115)
            {
                if ((a115 * a115 == b115 * b115 + c115 * c115) || (b115 * b115 == a115 * a115 + c115 * c115) || (c115 * c115 == b115 * b115 + a115 * a115))
                    Console.WriteLine("Day la 3 canh cua mot tam giac vuong");
                else
                    Console.WriteLine("Day khong phai la 3 canh cua mot tam giac vuong");
            }
            else
                Console.WriteLine("Day khong phai la 3 canh cua mot tam giac");

            Console.ReadKey();
        }
    }
}
