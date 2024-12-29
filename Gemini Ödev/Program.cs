using System;
using System.Collections.Generic;

namespace OgrenciNotSistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();

            Console.Write("Kaç öğrenci kaydetmek istiyorsunuz? ");
            int ogrenciSayisi = int.Parse(Console.ReadLine());

            for (int i = 0; i < ogrenciSayisi; i++)
            {
                Ogrenci ogrenci = new Ogrenci();
                Console.Write($"{i + 1}. öğrencinin numarası: ");
                ogrenci.Numara = int.Parse(Console.ReadLine());
                // Diğer bilgileri benzer şekilde al

                // Vize ve final notlarını doğrulama
                while (true)
                {
                    Console.Write($"{i + 1}. öğrencinin vize notu (0-100): ");
                    if (int.TryParse(Console.ReadLine(), out int vize) && vize >= 0 && vize <= 100)
                    {
                        ogrenci.Vize = vize;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen 0 ile 100 arasında bir değer giriniz.");
                    }
                }
                // Final notu için benzer doğrulama

                ogrenciler.Add(ogrenci);
            }

            // Tabloyu ekrana yazdırma
            Console.WriteLine("\nNumara\tAd\tSoyad\tVize\tFinal\tOrtalama\tHarf Notu");
            foreach (var ogrenci in ogrenciler)
            {
                Console.WriteLine($"{ogrenci.Numara}\t{ogrenci.Ad}\t{ogrenci.Soyad}\t{ogrenci.Vize}\t{ogrenci.Final}\t{ogrenci.Ortalama}\t{ogrenci.HarfNotu}");
            }

            // Sınıf ortalaması, en yüksek ve en düşük notu hesaplama ve yazdırma
            // ... (Bu kısmı kendiniz tamamlayabilirsiniz)
        }
    }

    class Ogrenci
    {
        public int Numara { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Vize { get; set; }
        public int Final { get; set; }
        public double Ortalama { get { return (Vize * 0.4) + (Final * 0.6); } }
        public string HarfNotu { get { return a(Ortalama); } }

        private string a (double ortalama)
        {
            // Harf notu hesaplama fonksiyonu (ödevdeki tabloya göre düzenleyebilirsiniz)
            // ...
        }
    }
}