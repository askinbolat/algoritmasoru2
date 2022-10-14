using System;

namespace algoritma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İlk pozitif sayıyı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci pozitif sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int[] sayiDizisi =new int[sayi2];
            for (int i = 0; i < sayi2; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz:",i+1);
                sayiDizisi[i] =int.Parse(Console.ReadLine());
            }

            foreach (var item in sayiDizisi)
            {
                if (item%sayi==0 || item==sayi)
                {
                    Console.WriteLine(item);
                }
                
                
            }
            
            
        }
    }
}