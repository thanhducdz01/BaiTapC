using System;

namespace tong_hop_11_bai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int chonBT_115;
            Console.WriteLine("=================== Chon Bai Tap ====================");
            Console.WriteLine("Bai 1: Nhập vào diện tích S của một mặt cầu. Tính thể tích V của hình cầu này");
            Console.WriteLine("Bai 2: Nhập vào tọa độ 2 điểm A(xA, yA) và B(xB, yB). Tính khoảng cách AB.");
            Console.WriteLine("Bai 6: Viết chương trình nhập vào ba số nguyên. Hãy in ba số này ra màn hình theo thứ tự tăng dần và chỉ dùng tối đa một biến phụ.");
            Console.WriteLine("Bai 7: Viết chương trình giải phương trình bậc 1: ax + b = 0 (a, b nhập từ bàn phím) Xét tất cả các trường hợp có thể.");
            Console.WriteLine("Bai 11: Viết trò chơi bao - đá - kéo");
            Console.WriteLine("Bai 13: Viết chương trình nhập vào ngày, tháng, năm. Kiểm tra ngày và tháng nhập có hợp lệ hay không. Tính thứ trong tuần của ngày đó");
            Console.WriteLine("Bai 20: Viết chương trình nhập số kW điện đã tiêu thụ");
            Console.WriteLine("Bai 22: Viết chương trình liệt kê, đếm và tính tổng các ước số của số nguyên dương n ");
            Console.WriteLine("Bai 23: Viết chương trình tìm các số hoàn hảo (perfect number) nhỏ hơn một số nguyên dương n cho trước");
            Console.WriteLine("Bai 31: Viết chương trình in bảng cửu chương từ 2 đến 9 ra màn hình");
            Console.WriteLine("Bai 36: Viết chương trình in ra n số nguyên tố đầu tiên (n nhập từ bàn phím)");

            do
            {
                Console.WriteLine("\nChon bai tap so (Nhap 0 de thoat): ");
                chonBT_115 = Convert.ToInt32(Console.ReadLine());
                switch (chonBT_115)
                {
                    case 1:
                        {
                            Console.WriteLine("Bai 1: Nhập vào diện tích S của một mặt cầu. Tính thể tích V của hình cầu này");
                            double S_115, r_115, V_115;
                            const double pi_115 = 3.141593;
                            Console.Write("Nhap vao dien tich S cua mat cau: ");
                            S_115 = Convert.ToDouble(Console.ReadLine());
                            r_115 = Math.Sqrt(S_115 / (4 * pi_115));
                            V_115 = (4 * pi_115 * Math.Pow(r_115, 3)) / 3;
                            Console.Write("The tich V : " + V_115 );
                        }

                        break;
                    case 2:
                        {
                            Console.WriteLine("Bai 2: Nhập vào tọa độ 2 điểm A(xA, yA) và B(xB, yB). Tính khoảng cách AB.");
                            double xA_115, yA_115, xB_115, yB_115, AB_115;
                            Console.Write("A(xA, yA)? ");
                            xA_115 = Convert.ToDouble(Console.ReadLine());
                            yA_115 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("B(xB, yB)? ");
                            xB_115 = Convert.ToDouble(Console.ReadLine());
                            yB_115 = Convert.ToDouble(Console.ReadLine());

                            AB_115 = Math.Abs(Math.Sqrt(Math.Pow(xB_115 - xA_115, 2) + Math.Pow(yB_115 - yA_115, 2)));

                            Console.WriteLine("|AB| = " + Math.Round(AB_115, 4));
                        }
                        break;
                    case 6:
                        {
                            Console.WriteLine("Bai 6: Viết chương trình nhập vào ba số nguyên. Hãy in ba số này ra màn hình theo thứ tự tăng dần và chỉ dùng tối đa một biến phụ.");
                            int a_115, b_115, c_115, temp_115;
                            Console.WriteLine("Nhap a, b, c: ");
                            a_115 = Convert.ToInt32(Console.ReadLine());
                            b_115 = Convert.ToInt32(Console.ReadLine());
                            c_115 = Convert.ToInt32(Console.ReadLine());

                            if (a_115 > b_115)
                            {
                                temp_115 = b_115;
                                b_115 = a_115;
                                a_115 = temp_115;
                            }
                            if (a_115 > c_115)
                            {
                                temp_115 = a_115;
                                a_115 = c_115;
                                c_115 = temp_115;
                            }
                            if (b_115 > c_115)
                            {
                                temp_115 = c_115;
                                c_115 = b_115;
                                b_115 = temp_115;
                            }


                            Console.WriteLine("tang dan {0}{1}{2}", a_115, b_115, c_115);
                        }
                        break;
                    case 7:
                        {
                            Console.WriteLine("Bai 7: Viết chương trình giải phương trình bậc 1: ax + b = 0 (a, b nhập từ bàn phím) Xét tất cả các trường hợp có thể.");
                            double a_115, b_115;

                            Console.WriteLine("Nhap a, b: ");

                            a_115 = Convert.ToDouble(Console.ReadLine());
                            b_115 = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Phuong trinh cua ban: {0}x + {1} = 0", a_115, b_115);

                            if (a_115 == 0)
                            {
                                Console.WriteLine("Phuong trinh vo nghiem");
                            }
                            else
                            {
                                if (b_115 == 0)
                                {
                                    Console.WriteLine("X = 0");
                                }
                                else
                                {
                                    Console.WriteLine("X = " + (-b_115 / a_115));
                                }
                            }
                        }
                        break;
                    case 11:
                        {
                            Console.WriteLine("Bai 11: Viết trò chơi bao - đá - kéo");
                            char n_115, m_115 = 'b';
                            int mRD_115, a_115 = 0, b_115 = 0;

                            while (true)
                            {
                                Console.WriteLine("Nhap ky tu (b-d-k) nhap ky tu khac de thoat: ");
                                n_115 = Convert.ToChar(Console.ReadLine());
                                Random rd = new Random();
                                mRD_115 = rd.Next(1, 3);
                                switch (mRD_115)
                                {
                                    case 1:
                                        {
                                            m_115 = 'b';
                                        }
                                        break;
                                    case 2:
                                        {
                                            m_115 = 'd';
                                        }
                                        break;
                                    case 3:
                                        {
                                            m_115 = 'k';
                                        }
                                        break;
                                }
                                switch (n_115)
                                {
                                    case 'b':
                                        {
                                            if (m_115 == 'd')
                                            {
                                                a_115++;
                                            }

                                            else
                                            {
                                                if (m_115 == 'k')
                                                    b_115++;
                                            }

                                        }
                                        break;
                                    case 'd':
                                        {
                                            if (m_115 == 'k')
                                            {
                                                a_115++;
                                            }

                                            else
                                            {
                                                if (m_115 == 'b')
                                                    b_115++;
                                            }
                                        }
                                        break;
                                    case 'k':
                                        {
                                            if (m_115 == 'b')
                                            {
                                                a_115++;
                                            }

                                            else
                                            {
                                                if (m_115 == 'd')
                                                    b_115++;
                                            }
                                        }
                                        break;
                                    default:
                                        return;
                                }
                                Console.WriteLine("n_115guoi: " + n_115);
                                Console.WriteLine("May: " + m_115);

                                Console.WriteLine("Ty so nguoi - may :{0} - {1} ", a_115, b_115);
                            };
                        }
                        break;
                    case 13:
                        {
                            Console.WriteLine("Bai 13: Viết chương trình nhập vào ngày, tháng, năm. Kiểm tra ngày và tháng nhập có hợp lệ hay không. Tính thứ trong tuần của ngày đó");
                            int d_115, m_115, y_115, top_115, dayofweek_115;

                            Console.WriteLine("Nhap vao ngay thang nam: ");
                            d_115 = Convert.ToInt32(Console.ReadLine());
                            m_115 = Convert.ToInt32(Console.ReadLine());
                            y_115 = Convert.ToInt32(Console.ReadLine());

                            if (y_115 < 1582)
                            {
                                Console.WriteLine("Nam khong hop le!\n Lich Gregorian bat dau tu nam 1582");
                            }
                            else
                            {
                                if (m_115 < 1 || m_115 > 12)
                                {
                                    Console.WriteLine("Thang khong hop le");
                                }
                                else
                                {
                                    if (((y_115 % 4 == 0 && y_115 % 100 != 0) || y_115 % 400 == 0) && m_115 == 2)
                                    {
                                        top_115 = 29;
                                    }
                                    else
                                    {
                                        if (m_115 == 1 || m_115 == 3 || m_115 == 5 || m_115 == 7 || m_115 == 8 || m_115 == 10 || m_115 == 12)
                                        {
                                            top_115 = 31;
                                        }
                                        else
                                        {
                                            top_115 = 30;
                                        }
                                    }
                                    if (d_115 < 1 && d_115 > top_115)
                                    {
                                        Console.WriteLine("Ngay khong hop le");
                                    }
                                    else
                                    {
                                        Console.WriteLine("hop le");
                                        y_115 -= (14 - m_115) / 12;
                                        m_115 += 12 * ((14 - m_115) / 12) - 2;
                                        dayofweek_115 = (d_115 + y_115 + y_115 / 4 - y_115 / 100 + y_115 / 400 + (31 * m_115) / 12) % 7;
                                        if (dayofweek_115 == 0)
                                            Console.WriteLine("Chu Nhat\n");
                                        else
                                            Console.WriteLine("Thu {0}", dayofweek_115 + 1);

                                    }
                                }
                            }
                        }
                        break;
                    case 20:
                        {
                            Console.WriteLine("Bai 20: Viết chương trình nhập số kW điện đã tiêu thụ");
                            double sokW_115, tongTien_115;
                            Console.WriteLine("Nhap sp kW dien: ");
                            sokW_115 = Convert.ToDouble(Console.ReadLine());

                            if (sokW_115 < 100)
                            {
                                tongTien_115 = sokW_115 * 500;
                            }
                            else
                            {
                                if (sokW_115 < 250)
                                {
                                    tongTien_115 = 100 * 500 + (sokW_115 - 100) * 800;
                                }
                                else
                                {
                                    if (sokW_115 < 350)
                                    {
                                        tongTien_115 = 100 * 500 + 150 * 800 + (sokW_115 - 250) * 1000;
                                    }
                                    else
                                    {
                                        tongTien_115 = 100 * 500 + 150 * 800 + 100 * 1000 + (sokW_115 - 350) * 1500;
                                    }
                                }
                            }
                            Console.WriteLine("Chi phi: " + tongTien_115);
                        }
                        break;
                    case 22:
                        {
                            Console.WriteLine("Bai 22: Viết chương trình liệt kê, đếm và tính tổng các ước số của số nguyên dương n ");
                            int a_115, sum_115 = 0, k_115 = 0;

                            Console.WriteLine("Nhap vao so nguyen duong: ");
                            a_115 = Convert.ToInt32(Console.ReadLine());
                            while (a_115 < 0)
                            {
                                Console.WriteLine("Nhap vap so nguyen duong!!");
                                a_115 = Convert.ToInt32(Console.ReadLine());
                            }
                            Console.Write("Cac uoc so: ");
                            for (int i = 1; i <= a_115; i++)
                            {
                                if (a_115 % i == 0)
                                {
                                    Console.Write(" " + i);
                                    k_115++;
                                    sum_115 += i;
                                }
                            }

                            Console.WriteLine("\nCo {0} uoc so, tong la : {1} ", k_115, sum_115);
                        }
                        break;
                    case 23:
                        {
                            Console.WriteLine("Bai 23: Viết chương trình tìm các số hoàn hảo (perfect number) nhỏ hơn một số nguyên dương n cho trước");
                            int n_115, i_115, j_115, sum_115;

                            Console.WriteLine("Nhap vao so n: ");
                            n_115 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Cac so hoan hao: ");
                            for (i_115 = 1; i_115 < n_115; i_115++)
                            {
                                sum_115 = 0;
                                for (j_115 = 1; sum_115 <= i_115 && j_115 < i_115; ++j_115)
                                {
                                    if (i_115 % j_115 == 0)
                                    {
                                        sum_115 += j_115;
                                    }
                                }
                                if (sum_115 == i_115)
                                {
                                    Console.Write(" " + i_115);
                                }
                            }
                        }
                        break;
                    case 31:
                        {
                            Console.WriteLine("Bai 31: Viết chương trình in bảng cửu chương từ 2 đến 9 ra màn hình");
                            Console.WriteLine("Chuong trinh in ra bang cuu chuong");

                            for (int i_115 = 1; i_115 <= 10; i_115++)
                            {
                                for (int j_115 = 2; j_115 <= 9; j_115++)
                                {
                                    Console.Write("| {0} x{1} = {2}\t", j_115, i_115, i_115 * j_115);
                                }
                                Console.WriteLine("");
                            }
                        }
                        break;
                    case 36:
                        {
                            Console.WriteLine("Bai 36: Viết chương trình in ra n số nguyên tố đầu tiên (n nhập từ bàn phím)");
                            int n_115, k_115 = 2, count_115;

                            Console.WriteLine("Nhap n: ");
                            n_115 = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Cac so nguyen to:");
                            for (int i = 1; i <= n_115;)
                            {
                                count_115 = 0;
                                for (int j = 2; j <= Math.Sqrt(k_115); j++)
                                {
                                    if (k_115 % j == 0)
                                    {
                                        count_115++;

                                    }
                                }

                                if (count_115 == 0)
                                {
                                    Console.Write(" " + k_115);
                                    i++;
                                }
                                k_115++;
                            }
                        }
                        break;
                    default:
                        if (chonBT_115 == 0)
                        {
                            Console.WriteLine("Thoat!!!");
                        }
                        else
                        {
                            Console.WriteLine("Khong co bai tap nay!");
                        }
                        break;
                }
            } while (chonBT_115 != 0);

            Console.ReadKey();

        }
    }
}
