using OgrenciYonetimSistemi.Interfaces;

namespace OgrenciYonetimSistemi.Classes
{
    public class OgretimGorevlisi : Person, IPerson
    {
        public string Department { get; set; }

        public override void BilgiGoster()
        {
            Console.WriteLine($"Ogretim Gorevlisi: {Name} {Surname}, Bolum: {Department}");
        }

        public void Login()
        {
            Console.WriteLine($"Ogretim Gorevlisi {Name} giriş yaptı.");
        }
    }
}