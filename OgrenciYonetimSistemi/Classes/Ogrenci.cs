using OgrenciYonetimSistemi.Interfaces;

namespace OgrenciYonetimSistemi.Classes
{
    public class Ogrenci : Person, IPerson
    {
        public string StudentNumber { get; set; }

        public override void BilgiGoster()
        {
            Console.WriteLine($"Ogrenci: {Name} {Surname}, Numara: {StudentNumber}");
        }

        public void Login()
        {
            Console.WriteLine($"Ogrenci {Name} giriş yaptı.");
        }
    }
}