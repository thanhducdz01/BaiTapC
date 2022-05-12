using System;

namespace BaiSo1
{
    class Program
    {
        static void Main(string[] args)
        {

            int soNguyen115;
            Console.WriteLine("Nhap vao so nguyen: ");
            soNguyen115 = Convert.ToInt32(Console.ReadLine());

            if (soNguyen115 >= 0)
                Console.WriteLine("Day la so nguyen  duong");
            else
                Console.WriteLine("Day la so nguyen am");
            Console.ReadKey();

        }
    }
}
