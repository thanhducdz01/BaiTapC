using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struc_enum
{
    class Program
    {
        public struct SinhVien
        {
            public int maSV_115;
            public string hoTen_115;
            public int tuoi_115;
            public double diemToan_115;
            public double diemLy_115;
            public double diemHoa_115;
            public int gioiTinh_115;

        }
        enum gioiTinh
        {
            nam_115,
            nu_115
        }

        static void NhapThongTinSinhVien(out SinhVien SV)
        {
            Console.WriteLine("");
            Console.Write(" Ma so: ");
            SV.maSV_115 = int.Parse(Console.ReadLine());
            Console.Write(" Ho ten: ");
            SV.hoTen_115 = Console.ReadLine();
            Console.Write(" Gioi tinh (0 - nam, 1 - nu): ");
            SV.gioiTinh_115 = int.Parse(Console.ReadLine());
            Console.Write(" Tuoi: ");
            SV.tuoi_115 = int.Parse(Console.ReadLine());
            Console.Write(" Diem toan: ");
            SV.diemToan_115 = Double.Parse(Console.ReadLine());
            Console.Write(" Diem ly: ");
            SV.diemLy_115 = Double.Parse(Console.ReadLine());
            Console.Write(" Diem van: ");
            SV.diemHoa_115 = Double.Parse(Console.ReadLine());
            
        }
        static double DiemTB(SinhVien SV)
        {
            return (SV.diemHoa_115 + SV.diemLy_115 + SV.diemHoa_115) / 3;
        }

        static void XuatThongTinSinhVien(SinhVien SV)
        {
            Console.WriteLine("=========");
            Console.WriteLine(" Ma so: " + SV.maSV_115);
            Console.WriteLine(" Ho ten: " + SV.hoTen_115);
            if (SV.gioiTinh_115 == (int)gioiTinh.nam_115)
            {
                Console.WriteLine(" Gioi tinh: Nam ");
            }
            if (SV.gioiTinh_115 == (int)gioiTinh.nu_115)
            {
                Console.WriteLine(" Gioi tinh: Nu");
            }
            Console.WriteLine(" Diem toan: " + SV.diemToan_115);
            Console.WriteLine(" Diem ly: " + SV.diemLy_115);
            Console.WriteLine(" Diem van: " + SV.diemHoa_115);
            Console.WriteLine(" Diem trung binh: " + DiemTB(SV));
            

        }
        static void Main(string[] args)
        { 
            
            int n_115;
            string ten_115 = "";
            Console.WriteLine("Nhap so luong sinh vien: ");

            n_115 = int.Parse(Console.ReadLine());

            SinhVien[] SV = new SinhVien[n_115];

            for (int i_115 = 0; i_115 < n_115; i_115++)
            {
                Console.Write("Nhap thong tin sinh vien thu {0}", i_115 + 1);
                NhapThongTinSinhVien(out SV[i_115]);
            }

            foreach(SinhVien sinhVien in SV)
            {
                Console.Write("Thong tin sinh vien: ");
                XuatThongTinSinhVien(sinhVien);
            }

            Console.Write("Nhap ten sinh vien can tim: ");
            ten_115 = Console.ReadLine();

            for (int i_115 = 0; i_115 < n_115; i_115++)
            {
                if (SV[i_115].hoTen_115.Equals(ten_115))
                {
                    Console.WriteLine("Diem trung binh: "+ DiemTB(SV[i_115]));
                }
            }


            Console.ReadKey();
            
        }
    }
}
