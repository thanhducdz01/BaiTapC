using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiKiemTra
{
    public class ptBac2
    {
        private double a_115, b_115, c_115;

        public ptBac2()
        {
        }

        public ptBac2(double a_115, double b_115, double c_115)
        {
            this.a_115 = a_115;
            this.b_115 = b_115;
            this.c_115 = c_115;
        }

        public double A { get => a_115; set => a_115 = value; }
        public double B { get => b_115; set => b_115 = value; }
        public double C { get => c_115; set => c_115 = value; }

        public double delta(double a_115, double b_115, double c_115)
        { 
            return (b_115*b_115 - 4*a_115*c_115);
        }

        public void nghiemPT(double a_115, double b_115, double c_115)
        {
            double del_115 = delta(a_115, b_115, c_115);
            if (a_115 == 0)
            {
                Console.WriteLine("Phuong trinh tro thanh bac nhat");
                Console.WriteLine("Co nghiem bang, x = {0}", -c_115 / b_115);
            }
            else
            {
                if (del_115 < 0)
                    Console.WriteLine("Phuong trinh vo nghiem");
                else if (del_115 == 0)
                    Console.WriteLine("Phuong trinh co nghiem kep, x1 = x2 = {0}", -b_115 / (2 * a_115));
                else
                {
                    Console.WriteLine("Phuong trinh co 2 nghiem phan biet");
                    Console.WriteLine("x1 = {0}", ((-b_115 + Math.Sqrt(del_115)) / (2 * a_115)));
                    Console.WriteLine("x2 = {0}", ((-b_115 - Math.Sqrt(del_115)) / (2 * a_115)));
                }
            }
        }
            
    }
}
