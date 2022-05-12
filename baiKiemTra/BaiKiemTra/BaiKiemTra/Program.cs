using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiKiemTra
{
    class Program
    {
        static void Main(string[] args)
        {
            double a_115, b_115, c_115;
            Console.WriteLine("Nhap a,b,c");
            a_115 = double.Parse(Console.ReadLine());
            b_115= double.Parse(Console.ReadLine());
            c_115 = double.Parse(Console.ReadLine());

            ptBac2 pt = new ptBac2();
            pt.nghiemPT(a_115, b_115, c_115);

            Console.ReadKey();
        }
    }
}
