using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Reflection.Emit;
using System.Text;
namespace P01_IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            mang9(5,6);

        }


        //A1.Viết chương trình tìm UCLN
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
        // A1.2.Viết chương trình tìm BCNN
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
        //A2.Viết chương trình tìm tổng các chữ số của một số nguyên
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

        //A3.Viết chương trình nhận vào một số nguyên và trả về cách phân tích số đó ra tích của thừa số nguyên tố. Ví dụ nhập vào 600 thì cần phải trả về 2 * 2 * 2 * 3 * 5 * 5
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
        //A4.Nhập vào số nguyên n, xuất ra danh sách những số fibonaci không lớn hơn n.

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
            bool kq = false;
            int j = sodoi.Length - 1;
            for(int i = 0; i< sodoi.Length/2; i++)
            {
                if (sodoi[i] == sodoi[j])
                {
                    kq = true;
                    j--;
                }       
                else
                {
                    kq = false;
                    break;
                }
            }
            return kq;
            
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
            int[] mang = { 1,1,2,1,3,3,4,5,6,2,0,3,0 };
            
            int[] new_mang = new int[0]; // Tạo mảng rỗng với 0 phần tử
            for (int i = 0; i < mang.Length; i++)
            {
                int dem = 1;
                for (int j = i + 1; j < mang.Length; j++)
                {
                    if (mang[j] == mang[i])
                    {
                        dem++;
                    }
                }

                //Nếu đếm hơn 2, có nghĩa là hơn xuất hiện trên 2 lần
                
                if (dem > 2)
                {
                    Array.Resize(ref new_mang, new_mang.Length + 1);
                    new_mang[new_mang.Length - 1] = mang[i];
                    // Hàm này thêm phần tử lặp trên 2 lần vào mảng rỗng ban đầu


                }
                

            }
            for (int k = 0; k < new_mang.Length; k++)
            {
                bool kq = true;
                for (int z = k+1; z < new_mang.Length; z++)
                {
                    if (new_mang[k] == new_mang[z]){
                        kq = false;
                        break;
                    }
                    // Ban đầu là true, nếu vong lặp gặp lại nó thì loại nó ko in ra
                }
                if(kq == true)
                {
                    Console.WriteLine(new_mang[k]);// Kết quả cuối in ra những số xuất hiện trên 2 lần
                }
                
            }

        }
        //M2.Viết chương trình tìm tìm tổng của 3 số lớn nhất trong một mảng số nguyên
        static int mang2()
        {
            //Hướng giải quyết: sắp xếp mảng lại từ cao xuống thấp, cộng 3 phần tử đầu
            int[] a = { 1, 5,7,5,8,2 };
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {

                for (int j = i + 1; j < a.Length; j++)
                {

                    if (a[i] < a[j])
                    {
                        int tam = a[i];
                        a[i] = a[j];
                        a[j] = tam;
                    }

                }
                sum = a[0] + a[1] + a[2] ;
                
            }
            return sum;
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
        //M5.Viết chương trình tìm mãng con liên tiếp tăng dần dài nhất từ một mảng số nguyên.DONE
        static void mang5()
        {
            int[] mang = { 4, 6, 6,7, 8,9, 2, 3,1, 3, 4, 5,6 };

            int tam = 0;// số phần tử của mảng con dài nhất
            int first = 0; // vị trí đầu tiên của mảng con dài nhất
            for (int i = 0; i < mang.Length; i++)
            {
                int dem = 1;// chiều dài ban đầu mảng con trong vong lặp
                
                for (int k = i; k < mang.Length-1; k++)
                {

                    int j = k + 1;
                    if (mang[j] > mang[k])
                    {
                        dem++;
                    }
                    else
                    {
                        break;
                    }


                }
                if (dem > tam)// lấy ra mảng dài nhất
                {
                    tam = dem;
                    first = i;

                }
                
            }
            for(int i = first; i < tam+first;i++) // lọc ra phần tử ban đầu + số phần tử của mảng
            {
                Console.Write(mang[i] + " ");
            }
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
        //M9.Viết chương trình tạo ngẫu nhiên một mảng gồm n số nguyên có giá trị từ 1 - m mà các giá trị không bị trùng lặp
        static void mang9(int n,int m)
        {
            int[] mang = new int[n];

            Random ran = new Random();
            mang[0] = ran.Next(1, m);
            for (int i = 1; i < mang.Length; i++)
            {
                int giatri = ran.Next(1, m);
                mang[i] = giatri;
                for (int j = i - 1; j > 0; j--)
                {

                    ngaunhien:
                    if (mang[j] == mang[i])
                    {
                        giatri = ran.Next(1, m);
                        mang[i] = giatri;
                        goto ngaunhien;
                    }
                    else
                    {
                        mang[i] = giatri;
                        continue;
                    }

                }

            }
            for (int i = 0; i < mang.Length; i++)
            {

                Console.WriteLine(mang[i] + " ");
            }
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

                    
                }
                //x[0][0].ToUpper();
                //string change = x[i][0];
                //change = x[i][0].ToUpper(change);
                //x[i][0] = change;
                Console.WriteLine(x[i][0]);

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
            string str = "abc 123 def 33 mn 3.221";
            //Thay the ki tu dac biet bang khoang trang
            string[] charsToRemove = new string[] { "@", ",", ".", ";", "'" };
          
            foreach (var c in charsToRemove)
            {
                str = str.Replace(c+"", " ");
            }
            //Thay the chu cai bang khoang trang
            for (char c = 'a'; c <= 'z'; c++)
            {
                str = str.Replace(c + "", " ");
                
            }
            str = str.Trim();//Loai bo khoang trag dau va cuoi chuoi
            string[] news = str.Split(" ");// chia chuoi thanh nhieu chuoi con
            int tong = 0;
            for(int i = 0;i< news.Length; i++)
            {
                if (news[i].Length > 0)
                {
                    // neu chuoi con co do dai >0 doi sang int cong vao
                    int a = int.Parse(news[i]);
                    tong += a;
                }
                
                
            }
            Console.WriteLine(tong);

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
        //S6.Nhận vào một chuổi ký tự chứa toàn các chữ cái (a-z, A-Z). Rút gọn chuỗi bằng cách ở những nơi chữ cái lặp lại, ta viết số lần lặp. Ví dụ abcccceeeeeefd sẽ viết thành abc4e6fd, abbbbbbbbbbbbbc viết là ab13c
        static void string6()
        {
            string s = "abbbbbbbbbbbbbc";
            string news = string.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                int dem = 1;
                string first = string.Empty;
                for (int j = i+1; j < s.Length; j++)
                {

                    
                    if (s[j] == s[i])
                    {
                        dem++;
                        first = dem.ToString();//convert int to string



                    }
                    else
                    {
                        first = s[i].ToString();
                    }
                    
                }
                Console.WriteLine(first);
                //Console.WriteLine("phan tu {0} co {1}", s[i], dem);
            }
            //Console.Write(news);

        }
    }
}