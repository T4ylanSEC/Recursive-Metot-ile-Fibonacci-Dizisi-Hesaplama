using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Metot_ile_Fibonacci_Dizisi_Hesaplama
{
    internal class Program
    {
        static int Fibonacci(int n)
        {
            if (n <= 1) // Temel durum: n = 0 veya n = 1
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Fibonacci Dizisindeki Eleman Sırasını Giriniz: ");
            int sayi = int.Parse(Console.ReadLine());

            int sonuc = Fibonacci(sayi);
            Console.WriteLine($"{sayi}. Fibonacci Sayısı: {sonuc}");

            Console.ReadKey();

        }
    }
}