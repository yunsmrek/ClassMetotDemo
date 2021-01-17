using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = 0001;
            musteri1.FirstName = "Ayşe";
            musteri1.LastName = "Yılmaz";
            musteri1.Age = 22;

            Musteri musteri2 = new Musteri();
            musteri2.ID = 0002;
            musteri2.FirstName = "Ali";
            musteri2.LastName = "Şeker";
            musteri2.Age = 32;

            Musteri musteri3 = new Musteri();
            musteri3.ID = 0003;
            musteri3.FirstName = "Seher";
            musteri3.LastName = "Kaçar";
            musteri3.Age = 27;

            Musteri musteri4 = new Musteri();
            musteri4.ID = 0004;
            musteri4.FirstName = "Selim";
            musteri4.LastName = "Kalkan";
            musteri4.Age = 26;

            Musteri[] musteriler = new Musteri[] { musteri1,musteri2,musteri3,musteri4 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.AddClient();
            musteriManager.RemoveClient(musteri1);
            
            musteriManager.ListClient(musteriler);

            
            
        }
        
    }
}
