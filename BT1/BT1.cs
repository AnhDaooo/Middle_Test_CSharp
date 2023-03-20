using System;
namespace BT1
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Tính số phần tử tối đa của mảng
            // Date of Birth: 19/06/2003
            int max = 19 + 6 + 3;
            double[] arr = new double[max];

            Console.Write("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap gia tri phan tu thu {0}: ", i);
                arr[i] = double.Parse(Console.ReadLine());
            }

            // in ra cac phan tu co phan nguyen chia het cho 6
            int sum = 6;
            Console.WriteLine("Cac phan tu co phan nguyen chia het cho {0}:", sum);
            for (int i = 0; i < n; i++)
            {
                if ((int)arr[i] % sum == 0)
                {
                    Console.Write("{0}\t", arr[i]);
                }
            }

            // Kiểm tra phần tử x có trong danh sách đã nhập hay không
            Console.Write("\nNhap gia tri x can kiem tra: ");
            double x = double.Parse(Console.ReadLine());
            bool isFound = false;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                {
                    isFound = true;
                    break;
                }
            }
            if (isFound)
            {
                Console.WriteLine("Gia tri {0} co trong danh sach.", x);
            }
            else
            {
                Console.WriteLine("Gia tri {0} khong co trong danh sach.", x);
            }

            // Đếm số lần xuất hiện của phần tử y trong danh sách đã nhập
            Console.Write("Nhap gia tri y can dem: ");
            double y = double.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == y)
                {
                    count++;
                }
            }
            Console.WriteLine("Gia tri {0} xuat hien {1} lan trong danh sach.", y, count);
        }
    }
}
