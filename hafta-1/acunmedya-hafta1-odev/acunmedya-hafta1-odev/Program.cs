using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n1- Sayının Pozitif, Negatif veya Sıfır Olduğunu Belirleme");
            Console.WriteLine("2- Gün İsmi Belirleme");
            Console.WriteLine("3- Basit Hesap Makinesi");
            Console.WriteLine("4- Üç Sayının En Büyüğünü Bulma");
            Console.WriteLine("5- Şifre Güçlülüğünü Kontrol Etme");
            Console.WriteLine("6- Çıkış");
            Console.Write("Seçiminizi yapın: ");

            int secim = int.Parse(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    PozitifNegatifSifir();
                    break;
                case 2:
                    GunIsmiBelirleme();
                    break;
                case 3:
                    HesapMakinesi();
                    break;
                case 4:
                    EnBuyukSayi();
                    break;
                case 5:
                    SifreKontrol();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Geçersiz seçim, tekrar deneyin.");
                    break;
            }
        }
    }

    // 1. Sayının Pozitif, Negatif veya Sıfır Olduğunu Belirleme
    static void PozitifNegatifSifir()
    {
        Console.Write("Bir sayı girin: ");
        int sayi = int.Parse(Console.ReadLine());

        if (sayi > 0)
            Console.WriteLine("Pozitif");
        else if (sayi < 0)
            Console.WriteLine("Negatif");
        else
            Console.WriteLine("Sıfır");
    }

    // 2. Gün İsmi Belirleme
    static void GunIsmiBelirleme()
    {
        Console.Write("Bir gün numarası girin (1-7): ");
        int gun = int.Parse(Console.ReadLine());

        switch (gun)
        {
            case 1: Console.WriteLine("Pazartesi"); break;
            case 2: Console.WriteLine("Salı"); break;
            case 3: Console.WriteLine("Çarşamba"); break;
            case 4: Console.WriteLine("Perşembe"); break;
            case 5: Console.WriteLine("Cuma"); break;
            case 6: Console.WriteLine("Cumartesi"); break;
            case 7: Console.WriteLine("Pazar"); break;
            default: Console.WriteLine("Geçersiz gün numarası!"); break;
        }
    }

    // 3. Basit Hesap Makinesi
    static void HesapMakinesi()
    {
        Console.Write("Birinci sayıyı girin: ");
        double sayi1 = double.Parse(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        double sayi2 = double.Parse(Console.ReadLine());

        Console.Write("İşlem seç (+, -, *, /): ");
        char islem = char.Parse(Console.ReadLine());

        switch (islem)
        {
            case '+': Console.WriteLine($"Sonuç: {sayi1 + sayi2}"); break;
            case '-': Console.WriteLine($"Sonuç: {sayi1 - sayi2}"); break;
            case '*': Console.WriteLine($"Sonuç: {sayi1 * sayi2}"); break;
            case '/':
                if (sayi2 != 0)
                    Console.WriteLine($"Sonuç: {sayi1 / sayi2}");
                else
                    Console.WriteLine("Bir sayı sıfıra bölünemez!");
                break;
            default: Console.WriteLine("Geçersiz işlem!"); break;
        }
    }

    // 4. Üç Sayının En Büyüğünü Bulma
    static void EnBuyukSayi()
    {
        Console.Write("Birinci sayıyı girin: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Üçüncü sayıyı girin: ");
        int c = int.Parse(Console.ReadLine());

        int enBuyuk;

        if (a > b && a > c)
            enBuyuk = a;
        else if (b > c)
            enBuyuk = b;
        else
            enBuyuk = c;

        Console.WriteLine($"En büyük sayı: {enBuyuk}");
    }

    // 5. Şifre Güçlülüğünü Kontrol Etme
    static void SifreKontrol()
    {
        Console.Write("Şifre girin: ");
        string sifre = Console.ReadLine();

        if (sifre.Length < 8)
        {
            Console.WriteLine("Şifre en az 8 karakter uzunluğunda olmalı!");
            return;
        }

        bool buyukHarfVar = false;
        bool ozelKarakterVar = false;
        string ozelKarakterler = "@#$%.";

        foreach (char c in sifre)
        {
            if (char.IsUpper(c))
                buyukHarfVar = true;
            if (ozelKarakterler.Contains(c))
                ozelKarakterVar = true;
        }

        if (buyukHarfVar && ozelKarakterVar)
            Console.WriteLine("Güçlü şifre!");
        else
            Console.WriteLine("Şifre en az bir büyük harf ve özel karakter içermeli!");
    }
}
