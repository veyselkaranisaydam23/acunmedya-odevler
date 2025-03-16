
/*
    Koşullu ifadeler, belirli bir koşulun doğru (true) veya yanlış (false) olmasına göre farklı 
kod bloklarının çalışmasını sağlar. if-else yapısı, programın farklı senaryolara tepki vermesine sebebiyet verir.

🔹 Gerçek Hayattan Örnek:
Bir asansör 600 kg’dan fazla yük taşıyamıyorsa, aşağıdaki gibi bir kontrol mekanizması kullanılabilir:

    if (agirlik > 600)
{
    Console.WriteLine("Aşırı yük! Asansöre binemezsiniz.");
}
else
{
    Console.WriteLine("Güvenli! Asansöre binebilirsiniz.");
}

    
    
 */


using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        // Tek mi çift mi kontrolü
        if (sayi % 2 == 0)
        {
            Console.WriteLine($"{sayi} çift bir sayıdır.");
        }
        else
        {
            Console.WriteLine($"{sayi} tek bir sayıdır.");
        }

        // Pozitif, negatif veya sıfır kontrolü
        if (sayi > 0)
        {
            Console.WriteLine($"{sayi} pozitif bir sayıdır.");
        }
        else if (sayi < 0)
        {
            Console.WriteLine($"{sayi} negatif bir sayıdır.");
        }
        else
        {
            Console.WriteLine("Girdiğiniz sayı sıfırdır.");
        }
    }
}
