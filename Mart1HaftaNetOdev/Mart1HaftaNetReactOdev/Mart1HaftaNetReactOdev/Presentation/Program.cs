using System;
using System.Linq;
using Business;
using DataAccess;
using Entities;

class Program
{
    static void Main()
    {
        // Veritabanı erişimi için repository ve service nesneleri oluşturuluyor
        IProgrammingLanguageRepository languageRepo = new ProgrammingLanguageRepository();
        ITechnologyRepository technologyRepo = new TechnologyRepository();
        IProgrammingLanguageService languageService = new ProgrammingLanguageManager(languageRepo);
        ITechnologyService technologyService = new TechnologyManager(technologyRepo);

        while (true)
        {
            // Ana menü
            Console.WriteLine("\n1. Yeni Programlama Dili Ekle");
            Console.WriteLine("2. Yeni Teknoloji Ekle");
            Console.WriteLine("3. Tüm Programlama Dillerini Listele");
            Console.WriteLine("4. Çıkış");
            Console.Write("Seçiminiz: ");
            string secim = Console.ReadLine();

            // Programlama dili eklemek
            if (secim == "1")
            {
                Console.Write("Programlama dili adı: ");
                string name = Console.ReadLine();
                // Yeni bir programlama dili oluşturuluyor ve listeye ekleniyor
                ProgrammingLanguage newLang = new ProgrammingLanguage { Id = languageService.GetLanguages().Count + 1, Name = name };
                languageService.AddLanguage(newLang);
                Console.WriteLine($"{name} eklendi!");
            }
            // Teknoloji eklemek
            else if (secim == "2")
            {
                Console.Write("Teknolojinin adı: ");
                string techName = Console.ReadLine();
                Console.Write("Ait olduğu programlama dilini seçin: ");
                string langName = Console.ReadLine();

                // Kullanıcıdan alınan programlama dili adıyla, o dilin var olup olmadığı kontrol ediliyor
                var programmingLanguage = languageService.GetLanguages().FirstOrDefault(l => l.Name == langName);
                if (programmingLanguage != null)
                {
                    // Yeni teknoloji oluşturuluyor
                    Technology newTech = new Technology
                    {
                        Id = technologyService.GetTechnologies().Count + 1,
                        Name = techName,
                        ProgrammingLanguage = programmingLanguage
                    };
                    // Teknoloji repository'ye ekleniyor ve programlama diline teknoloji ekleniyor
                    technologyService.AddTechnology(newTech);
                    programmingLanguage.Technologies.Add(newTech);
                    Console.WriteLine($"{techName} teknolojisi eklendi!");
                }
                else
                {
                    Console.WriteLine("Geçersiz programlama dili!");
                }
            }
            // Programlama dillerini listelemek
            else if (secim == "3")
            {
                Console.WriteLine("Programlama Dilleri:");
                // Tüm programlama dillerini listeliyoruz
                foreach (var lang in languageService.GetLanguages())
                {
                    Console.WriteLine($"- {lang.Name}");
                    if (lang.Technologies.Count > 0)
                    {
                        Console.WriteLine("Kullanılan Teknolojiler:");
                        // Bu dilin kullandığı tüm teknolojiler listeleniyor
                        foreach (var tech in lang.Technologies)
                        {
                            Console.WriteLine($"  - {tech.Name}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("  - Teknoloji bulunmamaktadır.");
                    }
                }
            }
            // Çıkış
            else if (secim == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Geçersiz seçim, tekrar deneyin.");
            }
        }
    }
}
