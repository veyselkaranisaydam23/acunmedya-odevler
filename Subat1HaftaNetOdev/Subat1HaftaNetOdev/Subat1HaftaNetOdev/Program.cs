using System;

class Program
{
    static void Main()
    {
        int[] sayilar = new int[5]; // 5 elemanlı dizi oluşturuldu
        Console.WriteLine("5 sayı girin:");

        for (int i = 0; i < sayilar.Length; i++)
        {
            Console.Write($"Sayı {i + 1}: ");
            sayilar[i] = Convert.ToInt32(Console.ReadLine()); // Kullanıcıdan giriş al
        }

        Console.WriteLine("\nGirilen Sayılar:");
        foreach (int sayi in sayilar)
        {
            Console.Write(sayi + " ");
        }

        // Dizideki en büyük sayıyı bul
        int enBuyuk = sayilar[0]; // İlk elemanı başlangıç olarak al

        foreach (int sayi in sayilar)
        {
            if (sayi > enBuyuk)
                enBuyuk = sayi;
        }

        Console.WriteLine("\nDizideki en büyük sayı: " + enBuyuk);
    }
}
