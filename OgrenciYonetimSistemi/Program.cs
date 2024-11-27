using System;
using OgrenciYonetimSistemi.Classes;

namespace OgrenciYonetimSistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            OgretimGorevlisi ogretmen = new OgretimGorevlisi
            {
                ID = 1,
                Name = "Muhammet ALi",
                Surname = "Karakaya",
                Department = "Bilgisayar Programcılığı"
            };

            Ogrenci ogrenci1 = new Ogrenci
            {
                ID = 1,
                Name = "Ecem",
                Surname = "Acar",
                StudentNumber = "20231001"
            };

            Ogrenci ogrenci2 = new Ogrenci
            {
                ID = 2,
                Name = "İrem",
                Surname = "Demir",
                StudentNumber = "20231002"
            };

            Ders ders = new Ders
            {
                DersAdi = "Programlama 101",
                Kredi = 4,
                OgretimGorevlisi = ogretmen
            };

            ders.Ogrenciler.Add(ogrenci1);
            ders.Ogrenciler.Add(ogrenci2);

            Console.WriteLine("Ders Bilgisi:");
            ders.DersBilgisiGoster();
        }
    }
}