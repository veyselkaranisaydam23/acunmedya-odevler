using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- MENÜ ---");
            Console.WriteLine("1. Sayının Rakamlarının Toplamı");
            Console.WriteLine("2. Belirli Şartlara Uygun Sayı Alma");
            Console.WriteLine("3. Yaş Kategorisi Belirleme");
            Console.WriteLine("4. Tekrar Eden Elemanları Bulma");
            Console.WriteLine("5. En Uzun ve En Kısa Kelimeyi Bulma");
            Console.WriteLine("6. Cümleyi Alfabetik Sıralama");
            Console.WriteLine("7. String Dizisinin Boyutunu Artırma");
            Console.WriteLine("8. Kelimeleri Listeye Kaydedip Tersten Yazdırma");
            Console.WriteLine("9. Rastgele Sayılar ile İşlemler");
            Console.WriteLine("10. 10’dan Küçük Sayıları Silme");
            Console.WriteLine("11. 50’den Küçük Notları Güncelleme");
            Console.WriteLine("0. Çıkış");
            Console.Write("Seçiminizi yapın: ");

            int choice = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (choice)
            {
                case 1:
                    Console.Write("Sayı girin: ");
                    int num = int.Parse(Console.ReadLine());
                    Console.WriteLine("Rakamların toplamı: " + num.ToString().Sum(c => c - '0'));
                    break;

                case 2:
                    int value;
                    do
                    {
                        Console.Write("10 ile 100 arasında bir sayı girin: ");
                        value = int.Parse(Console.ReadLine());
                    } while (value < 10 || value > 100);
                    Console.WriteLine("Geçerli sayı: " + value);
                    break;

                case 3:
                    int[] ages = { 5, 16, 25, 70 };
                    foreach (int age in ages)
                        Console.WriteLine($"{age} yaşında: " + (age <= 12 ? "Çocuk" : age <= 19 ? "Genç" : age <= 64 ? "Yetişkin" : "Yaşlı"));
                    break;

                case 4:
                    int[] numbers = { 1, 2, 3, 4, 2, 3, 5, 6, 1 };
                    var duplicates = numbers.GroupBy(n => n).Where(g => g.Count() > 1).Select(g => g.Key);
                    Console.WriteLine("Tekrar eden sayılar: " + string.Join(", ", duplicates));
                    break;

                case 5:
                    string[] words = { "elma", "muz", "karpuz", "çilek" };
                    Console.WriteLine("En uzun: " + words.OrderByDescending(w => w.Length).First());
                    Console.WriteLine("En kısa: " + words.OrderBy(w => w.Length).First());
                    break;

                case 6:
                    Console.Write("Cümle girin: ");
                    string[] sentence = Console.ReadLine().Split(' ').OrderBy(w => w).ToArray();
                    Console.WriteLine("Sıralı: " + string.Join(", ", sentence));
                    break;

                case 7:
                    List<string> dynamicList = new List<string> { "elma", "armut" };
                    dynamicList.Add("çilek");
                    Console.WriteLine("Güncellenmiş dizi: " + string.Join(", ", dynamicList));
                    break;

                case 8:
                    List<string> wordList = new List<string>();
                    Console.WriteLine("Kelime girin (Çıkış için 'exit'): ");
                    while (true)
                    {
                        string input = Console.ReadLine();
                        if (input.ToLower() == "exit") break;
                        wordList.Add(input);
                    }
                    wordList.Reverse();
                    Console.WriteLine("Tersten: " + string.Join(", ", wordList));
                    break;

                case 9:
                    List<int> numList = new List<int>();
                    Console.WriteLine("Sayı girin (Çıkış için 'exit'): ");
                    while (true)
                    {
                        string inp = Console.ReadLine();
                        if (inp.ToLower() == "exit") break;
                        numList.Add(int.Parse(inp));
                    }
                    Console.WriteLine($"Ortalama: {numList.Average()}");
                    numList.Sort();
                    Console.WriteLine("Sıralı: " + string.Join(", ", numList));
                    break;

                case 10:
                    List<int> filterList = new List<int> { 5, 10, 15, 3, 8, 20 };
                    filterList.RemoveAll(n => n < 10);
                    Console.WriteLine("Güncellenmiş Liste: " + string.Join(", ", filterList));
                    break;

                case 11:
                    List<int> grades = new List<int> { 45, 60, 30, 80, 49 };
                    grades = grades.Select(g => g < 50 ? 50 : g).ToList();
                    Console.WriteLine("Güncellenmiş Notlar: " + string.Join(", ", grades));
                    break;

                case 0:
                    return;

                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }
        }
    }
}
