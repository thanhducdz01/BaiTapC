using System;

namespace BaiSo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bai tap 2");
            int sn115;
            Console.WriteLine("Nhap vao so nguyen: ");
            sn115 = Console.Read();
            if (sn115 == 49)
                Console.WriteLine("Một");
            if (sn115 == 50)
                Console.WriteLine("Hai");
            if (sn115 == 51)
                Console.WriteLine("Ba");
            if (sn115 == 52)
                Console.WriteLine("Bốn");
            if (sn115 == 53)
                Console.WriteLine("Năm");
            if (sn115 == 54)
                Console.WriteLine("Sáu");
            if (sn115 == 55)
                Console.WriteLine("Bảy");
            if (sn115 == 56)
                Console.WriteLine("Tám");
            if (sn115 == 57)
                Console.WriteLine("Chín");
            if (sn115 == 48)
                Console.WriteLine("Không");
            Console.ReadKey();
        }
    }
}
