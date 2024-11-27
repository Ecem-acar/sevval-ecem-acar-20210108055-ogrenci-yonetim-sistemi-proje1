using System;
using System.Collections.Generic;

namespace OgrenciYonetimSistemi.Classes
{
    public class Ders
    {
        public string DersAdi { get; set; }
        public int Kredi { get; set; }
        public OgretimGorevlisi OgretimGorevlisi { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; }

        public Ders()
        {
            Ogrenciler = new List<Ogrenci>();
        }

        public void DersBilgisiGoster()
        {
            Console.WriteLine($"Ders: {DersAdi}, Kredi: {Kredi}, Ogretim Gorevlisi: {OgretimGorevlisi.Name} {OgretimGorevlisi.Surname}");
            Console.WriteLine("Kayitli Ogrenciler:");
            foreach (var ogrenci in Ogrenciler)
            {
                Console.WriteLine($"- {ogrenci.Name} {ogrenci.Surname}");
            }
        }
    }
}