/*
 Döngüler (for, while)
Döngüler, belirli bir işlemi tekrarlamak için kullanılır. For döngüsü, 
genellikle tekrar sayısının belli olduğu durumlarda kullanılırken, while 
döngüsü koşul sağlandığı sürece çalışır ve genellikle tekrar sayısının 
önceden bilinmediği durumlarda tercih edilir.
 */

using System;

class Program
{
    static void Main()
    {
        // 1’den 10’a kadar olan sayıları ekrana yazdırma
        Console.WriteLine("1’den 10’a kadar olan sayılar:");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine("\n----------------------");

        // Kullanıcıdan alınan sayıya kadar olan sayıların toplamını hesaplama
        Console.Write("Bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        int toplam = 0;
        for (int i = 1; i <= sayi; i++)
        {
            toplam += i;
        }

        Console.WriteLine($"1'den {sayi}'e kadar olan sayıların toplamı: {toplam}");
    }
}
