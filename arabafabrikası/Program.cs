using System;
using System.Collections.Generic;

class Araba
{
    public DateTime UretimTarihi { get; set; }
    public string SeriNumarasi { get; set; }
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Renk { get; set; }
    public int KapiSayisi { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Araba> arabalar = new List<Araba>();

        while (true)
        {
            // 1. Kullanıcıya araba üretmek isteyip istemediği soruluyor.
            Console.Write("Araba üretmek ister misiniz? (Evet - e / Hayır - h): ");
            string cevap = Console.ReadLine().ToLower();

            if (cevap == "h")
            {
                break; // Hayır cevabı verilirse program sonlanır.
            }
            else if (cevap != "e")
            {
                Console.WriteLine("Geçersiz bir cevap verdiniz. Lütfen 'e' veya 'h' harflerinden birini girin.");
                continue; // Geçersiz cevaba tekrar soru sorulur.
            }

            // 2. Yeni bir araba nesnesi oluşturuluyor.
            Araba yeniAraba = new Araba();
            yeniAraba.UretimTarihi = DateTime.Now;

            // Seri Numarası
            Console.Write("Seri Numarası: ");
            yeniAraba.SeriNumarasi = Console.ReadLine();

            // Marka
            Console.Write("Marka: ");
            yeniAraba.Marka = Console.ReadLine();

            // Model
            Console.Write("Model: ");
            yeniAraba.Model = Console.ReadLine();

            // Renk
            Console.Write("Renk: ");
            yeniAraba.Renk = Console.ReadLine();

            // Kapı Sayısı
            while (true)
            {
                Console.Write("Kapı Sayısı: ");
                string kapıSayisiStr = Console.ReadLine();

                try
                {
                    yeniAraba.KapiSayisi = int.Parse(kapıSayisiStr); // Sayısal değeri parse etmeye çalışıyoruz.
                    break; // Eğer başarılıysa çıkıyoruz.
                }
                catch (FormatException)
                {
                    Console.WriteLine("Geçersiz bir sayı girdiniz. Lütfen sadece sayısal bir değer girin.");
                }
            }

            // 5. Araba nesnesini listeye ekleyelim.
            arabalar.Add(yeniAraba);

            // 6. Başka araba oluşturmak isteyip istemediğini soruyoruz.
            Console.Write("Başka bir araba üretmek ister misiniz? (Evet - e / Hayır - h): ");
            string devamCevap = Console.ReadLine().ToLower();

            if (devamCevap == "h")
            {
                break; // Hayır cevabı verilirse döngü sonlanır.
            }
        }

        // 7. Arabaların seri numarası ve marka bilgilerini yazdıralım.
        Console.WriteLine("\nÜretilen Arabalar:");
        foreach (var araba in arabalar)
        {
            Console.WriteLine($"Seri Numarası: {araba.SeriNumarasi}, Marka: {araba.Marka}");
        }
    }
}
