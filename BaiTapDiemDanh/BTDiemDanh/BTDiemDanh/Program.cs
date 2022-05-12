using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDiemDanh
{
    class Program
    {
        public static void input(out int[] arr_115)
        {
            arr_115 = new int[10];
            Console.WriteLine("Nhap gia tri mang: ");
            for (int i = 0; i < 10; i++) { 
                arr_115[i] = Int32.Parse(Console.ReadLine());
            }
        }

        public static void output(int[] arr_115)
        {
            Console.WriteLine("Mang vua nhap: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(arr_115[i] + " ");
            }
            Console.WriteLine("");
        }

        public static void Max_Min(int[] arr_115)
        {
            int max_115 = arr_115[0];

            for(int i = 0; i < 10; i++)
            {
                if (arr_115[i] > max_115)
                {
                    max_115 = arr_115[i];
                }
            }
            Console.WriteLine("So lon nhat: " + max_115);

            int min_115 = arr_115[0];
            for(int i = 0; i < 10; i++)
            {
                if(arr_115[i] < min_115)
                {
                    min_115 = arr_115[i];
                }
            }
            Console.WriteLine("So nho nhat: " + min_115);

        }

        public static void sortArr(int[] arr_115)
        {
            int tmp_115;
            int[] arr2_115 = arr_115;
            int[] arr3_115 = arr_115;
            //tang dan
            for (int i = 0; i < 9; i++)
            {
                for (int j = i + 1; j < 8; j++)
                {
                    if (arr2_115[i] > arr2_115[j])
                    {
                        
                        tmp_115 = arr2_115[i];
                        arr2_115[i] = arr2_115[j];
                        arr2_115[j] = tmp_115;
                    }
                }
            }
            Console.WriteLine("Mang sau khi sap xep tang dan:");
            output(arr_115);
            //giam dan

            for (int i = 0; i < 9; i++)
            {
                for (int j = i + 1; j < 8; j++)
                {
                    if (arr3_115[i] < arr3_115[j])
                    {
                        
                        tmp_115 = arr3_115[i];
                        arr3_115[i] = arr3_115[j];
                        arr3_115[j] = tmp_115;
                    }
                }
            }
            Console.WriteLine("mang sau khi sap xep giam dan:");
            output(arr_115);
        }
        static void Main(string[] args)
        {
            int[] arr_115;

            input(out arr_115);
            output(arr_115);

            Max_Min(arr_115);

            sortArr(arr_115);

            Console.ReadKey();
        }
    }
}
