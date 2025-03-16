using System;

class Program
{
    static void Main()
    {
        // Bellek Kullanımı Karşılaştırması
        int x = 5;        // 4 byte
        double y = 5.2;   // 8 byte
        string name = "Mehmet";  // Dinamik bellek kullanımı

        Console.WriteLine("Bellek Kullanımı:");
        Console.WriteLine($"int x = {x}; // 4 byte");
        Console.WriteLine($"double y = {y}; // 8 byte");
        Console.WriteLine($"string name = \"{name}\"; // Dinamik boyutlu\n");

        // Kullanıcıdan iki sayı alıp toplamını hesaplama
        Console.Write("Birinci sayıyı girin: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        double toplam = sayi1 + sayi2;
        Console.WriteLine($"Toplam: {toplam}");
    }
}
