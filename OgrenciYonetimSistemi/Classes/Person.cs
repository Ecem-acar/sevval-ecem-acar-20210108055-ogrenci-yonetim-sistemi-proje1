namespace OgrenciYonetimSistemi.Classes
{
    public abstract class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public abstract void BilgiGoster();
    }
}