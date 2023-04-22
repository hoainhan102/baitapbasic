using System;
using System.Text;
namespace P01_IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            string2();
            //Console.WriteLine(mang2());




        }


        // 1.Viết chương trình tìm UCLN
        static int UCLN(int a, int b)
        {
            int ucln = 1;
            for (int i = 1; i <= a && i <= b; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    ucln = i;
                }
            }
            return ucln;
        }
        // 1.BCNN của hai số tự nhiên
        static int BCNN(int a, int b)
        {
            int ucln = 1;
            for (int i = 1; i <= a && i <= b; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    ucln = i;
                }
            }
            int bcnn = (a * b) / ucln;
            return bcnn;
        }
        //2.Viết chương trình tìm tổng các chữ số của một số nguyên
        static void bai2_tongsonguyen()
        {
            Console.WriteLine("\nNhap vao mot so nguyen lon hon 0: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = x;
            int tong = 0;
            while (x <= 0)
            {
                Console.WriteLine("\nVui long nhap lai: ");
                x = Convert.ToInt32(Console.ReadLine());
                y = x;

            }
            while (x > 0)
            {

                tong += x % 10;
                x /= 10;
            }
            Console.WriteLine("\nSo nguyen la " + y);
            Console.WriteLine("\nTong so nguyen la: " + tong);
        }

        //3.Viết chương trình nhận vào một số nguyên và
        //trả về cách phân tích số đó ra tích của thừa số nguyên tố.
        //Ví dụ nhập vào 600 thì cần phải trả về 2 * 2 * 2 * 3 * 5 * 5
        static void bai3()
        {
            int a = 600;
            for (int i = 2; i <= a;)
            {
                if (a % i == 0)
                {

                    Console.Write(i);
                    if (a != i)
                    {
                        Console.Write("*");
                    }
                    a = a / i;

                }
                else
                {
                    i++;
                }
            }
        }
        // Bai4.Số fibonaci

        static int fibo(int n)
        {
            int f0 = 0;
            int f1 = 1;
            int fn = 1;
            if (n < 0)
            {
                return -1;
            }
            else if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    f0 = f1;
                    f1 = fn;
                    fn = f0 + f1;

                }



            }
            return fn;

        }

        //Bai6 Viết phương trình nhập vào n và in ra tổng của dãy số

        static int bai6(int x)
        {
            int a = 0;
            int b = a + 1;
            int c = a * b;
            int sum = a * b;
            for (int i = 1; i <= x; i++)
            {
                a = b;
                b = a + 1;
                c = a * b;
                sum += c;

            }
            return sum;
        }
        //Bai7 Viết phương trình tính giai thừa n! của một số
        static long giaithua(long n)
        {
            long giaithua = 1;
            for (int i = 1; i <= n; i++)
            {
                giaithua = giaithua * i;
            }
            return giaithua;
        }
        public static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        //Bai8 Viết chương trình tính pi với độ sai số 0.0001 bằng công thức
        static double tinhpi()
        {
            //Console.WriteLine(Math.Round(tinhpi(), 5));

            double picong = 0;
            double pitru = 0;
            double pi = 0;

            for (int i = 1; i <= 1000000;)
            {
                picong += (4f / i);
                i = i + 4;
            }
            for (int i = 3; i <= 1000000;)
            {
                pitru += (4f / i);
                i = i + 4;
            }
            return pi = picong - pitru;
        }

        //12. Viết hàm nhận vào một số nguyên n, kiểm tra số nguyên n có phải là số đối xứng

        static bool songuyen(int n)
        {
            string sodoi = n.ToString();
            string s = new string(sodoi.Reverse().ToArray());
            if (sodoi == s)
            {
                return true;
            }
            else
            {
                return false;
            }
            {

            }
        }
        //14. Cho số nguyên n, tính số chữ số 0 ở cuối khi tính n!
        static long so0(int n)
        {
            long a = giaithua(n);
            int dem = 0;
            do
            {
                dem++;
                a = a / 10;
            }
            while (a % 10 == 0);
            return dem;
        }
        //15. Cho số nguyên n, tính số chữ số của n!
        static int bai15(int n)
        {
            long a = giaithua(n);

            string gt = a.ToString();

            int b = gt.Length;

            return b;

        }
        //16. Viết chương trình kiểm tra nếu số nguyên n chỉ chia hết cho các số nguyên tố là 2, 3, 5
        static bool bai16(int n)
        {
            if (n % 2 == 0 && n % 3 == 0 & n % 5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //17.Viết chương trình nhập vào số nguyên n, tìm số m sao cho cả 3 điều kiện
        static long bai17(int n)
        {
            long m = n;
        songuyento:
            for (int i = 2; i < m; i++)
            {
                if (m % i == 0)
                {
                    m++;
                }


            }
            string m1 = m.ToString();
            string m2 = new string(m1.Reverse().ToArray());
            if (m1 == m2)
            {
                return m;
            }
            else
            {
                m++;
                goto songuyento;
            }

        }
        //M1.Viết chương trình tìm những số xuất hiện trên 2 lần trong một mảng số nguyên
        static void mang1()
        {
            int[] mang = { 1, 2, 3, 3, 4, 1, 2, 5, 7, 6, 3 };

            for (int i = 0; i < mang.Length; i++)
            {
                int dem = 1;
                for (int j = i + 1; j < mang.Length; j++)
                {
                    if (mang[j] == mang[i])
                    {
                        //mang[j] = false;
                        dem++;
                    }
                }

                if (dem > 1)
                {
                    Console.Write("\nSo {0} xuat hien {1} lan", mang[i], dem);
                }
            }
        }
        //M2.Viết chương trình tìm tìm tổng của 3 số lớn nhất trong một mảng số nguyên
        static int mang2()
        {
            int[] mang = { 1, 2, 3, 3, 4, 3, 2, 5, 7, 6, 3 };
            int so1 = 0;
            int so2 = 0;
            int so3 = 0;

            for (int i = 0; i < mang.Length; i++)

            {
                so1 = mang[i];
                for (int j = i + 1; j < mang.Length; j++)
                {
                    if (mang[i] >= mang[j])
                    {
                        so2 = mang[j];
                    }
                    else
                    {
                        so1 = mang[j];
                        so2 = mang[i];
                    }

                }

            }
            return so1 + so2;
        }
        //M3.Viết chương trình tìm tổng của các số chẵn và trừ đi tổng các số lẻ trong một mảng số nguyên
        static int mang3()
        {
            int[] mang = { 1, 2, 3, 3, 4, 3, 2, 5, 7, 6, 3 };
            int tongchan = 0;
            int tongle = 0;

            for (int i = 0; i < mang.Length; i++)
            {
                if (mang[i] % 2 == 0)
                {
                    tongchan += mang[i];
                }
                else
                {
                    tongle += mang[i];
                }
            }
            int ketqua = tongchan - tongle;
            return ketqua;
        }
        //M4.Viết chương trình tính tổng của các số nguyên tố trong một mảng số nguyên
        static int mang4()
        {
            int[] mang = { 1, 3, 5, 10, 11, 17, 20 };
            int tong = 0;

            for (int i = 0; i < mang.Length; i++)
            {
                int songuyento = 0;
                int dem = 0;
                for (int j = 2; j < mang[i]; j++)

                {

                    if (mang[i] == 1 || mang[i] == 2)
                    {
                        dem = 0;
                    }
                    else if (mang[i] > 2)
                    {

                        if (mang[i] % j == 0)
                        {
                            dem++;
                        }


                    }
                    else
                    {
                        dem = -1;
                    }


                }
                if (dem == 0)
                {
                    songuyento = mang[i];
                    tong += songuyento;
                }

            }
            return tong;
        }
        //M7.Viết chương trình chia một mảng số nguyên thành các mảng con có số lượng phần tử bằng nhau và bằng n (Riêng mảng cuối cùng có thể có số phần tử ít hơn do đủ) 
        static void mang7()
        {
            int[] mang = { 3, 5, 7, 9, 15, 10, 30, 12, 34, 55, 32, 5, 76, 77, 78, 53, 22 };
            int n = 3;
            int a = mang.Length / n;
            int first = 1;
            for (int i = 0; i < mang.Length; i++)
            {

                if (i < n * first)
                {
                    Console.Write(mang[i] + " ");

                }
                else
                {
                    Console.WriteLine();
                    i = n * first - 1;
                    first++;
                }

            }
        }
        //M8.Viết chương trình đếm xem có bao nhiêu số chia hết cho 3 nhưng không chia hết cho 5 trong 1 mảng 1 chiều
        static int mang8()
        {
            int[] mang = { 3, 5, 7, 9, 15, 10, 30, 12 };
            int dem = 0;


            for (int i = 0; i < mang.Length; i++)
            {
                if (mang[i] % 3 == 0 && mang[i] % 5 != 0)
                {
                    dem++;
                }

            }
            return dem;
        }
        //M10.Viết chương trình tính tổng các số chính phương từ mảng 1 chiều
        static int mang10()
        {
            int[] mang = { 3, 5, 7, 9, 16, 10, 25, 12 };
            int tong = 0;


            for (int i = 0; i < mang.Length; i++)
            {
                int songuyen = (int)Math.Sqrt(mang[i]);
                if (songuyen * songuyen == mang[i])
                {
                    tong += mang[i];
                }

            }
            return tong;
        }
        //S1.Viết chương trình chuyển hoá một tên biến từ UpperCase về snake_case. Ví dụ MyProgram thành my_program
        static void string1()
        {
            string s = "BaiTapChuoi";
            for (char c = 'A'; c <= 'Z'; c++)
            {
                s = s.Replace(c + "", "_" + c + "");

            }
            //s = s.Replace(s[0], "");
            s = s.ToLower().Remove(0, 1);
            Console.Write(s);
        }
        //S2.Viết chương trình chuyển hoá một tên biến từ snake_case về UpperCase.CHUAXONG
        static void string2()
        {
            string s = "bai_tap_chuoi";
            string[] x = s.Split('_');
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < x[i].Length; j++)
                {
                    x[0] = x[0].ToUpper();

                }
                Console.WriteLine(x[i]);

            }
            //s = s.ToUpper();
            for (char c = 'a'; c <= 'z'; c++)
            {
                //s = s.Replace("_" + c + "", c + "");

            }
            //s = s.Replace(s[0], "");
            // s = s.ToLower().Remove(0, 1);
            //Console.Write(s);
        }
        //S3.Viết chương trình đảo ngược thứ tự của các ký tự trong chuỗi.
        static void string3()
        {
            string s = "BaiTapChuoi";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }

        }
        //S4.Tính tổng của các số nguyên trong chuỗi. Ví dụ abc 123 def 33 mn 3.221 sẽ in ra 380 với 380 = 123+33+3+221
        static void string4()
        {
            string s = "BaiTapChuoi";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }

        }
        //S5.Kiểm tra chuỗi ký tự có đối xứng hay không. (Ví dụ abcdcba là đối xứng)
        static void string5()
        {
            string s = "abcdcba";
            bool check = false;
            int j = s.Length - 1;
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] == s[j])
                {
                    check = true;
                }

                j--;
            }
            Console.Write(check);

        }
    }
}