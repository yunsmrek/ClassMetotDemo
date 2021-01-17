using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        int Sayici = 0;
        public void AddClient()
        {
            Console.WriteLine("İsim = ");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Soyisim = ");
            string LastName = Console.ReadLine();
            Console.WriteLine("Yaş = ");
            int Age =Convert.ToInt32(Console.ReadLine());
            switch (Sayici)
            {
                case 0:
                    Musteri musteri5 = new Musteri();
                    musteri5.ID = 0005;
                    musteri5.FirstName = FirstName;
                    musteri5.LastName = LastName;
                    musteri5.Age = Age;
                    break;
                case 1:
                    Musteri musteri6 = new Musteri();
                    musteri6.ID = 0006;
                    musteri6.FirstName = FirstName;
                    musteri6.LastName = LastName;
                    musteri6.Age = Age;
                    break;
                case 2:
                    Musteri musteri7 = new Musteri();
                    musteri7.ID = 0007;
                    musteri7.FirstName = FirstName;
                    musteri7.LastName = LastName;
                    musteri7.Age = Age;
                    break;

            }


            Sayici++;
        }
        public void RemoveClient(Musteri musteri)
        {
            Console.WriteLine(musteri.FirstName+" Kişisi Siliniyor");
            musteri.FirstName = null;
            musteri.LastName = null;
            musteri.Age = 0;
            musteri.ID = 0;
        }
        public void ListClient(Musteri[] musteri)
        {
            foreach (var musteriler in musteri)
            {
                Console.WriteLine("Müşteri Adı: " + musteriler.FirstName + " Soyadı: " + musteriler.LastName + " Yaşı: " + musteriler.Age);
            }
            
        }
        
    }
}
