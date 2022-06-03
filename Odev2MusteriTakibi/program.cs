using System;
using System.Collections.Generic;

namespace Odev2MusteriTakibi
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 511234789;
            musteri1.Name = "Kerem";
            musteri1.Surname = "Varis";
            musteri1.Age = 32;
            musteri1.Mail = "KeremVaris@gmail.com";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 71236890;
            musteri2.Name = "Muhammet Taha";
            musteri2.Surname = "Adiyaman";
            musteri2.Age = 22;
            musteri2.Mail = "muhammettahaadiyaman@gmail.com";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 71236521;
            musteri3.Name = "Ecem";
            musteri3.Surname = "Bekim";
            musteri3.Age = 21;
            musteri3.Mail = "Ecembekim@gmail.com";

            //Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            List<Musteri> musteriler = new List<Musteri> { musteri1, musteri2, musteri3 };    
            
            MusteriManager musteriManager = new MusteriManager(); //copy
            //musteri ekleme bölümü
            
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);

            //müşterilerimizi üç türlü listeleyebiliriz ilk olarak alt alta burada basarak, ikinci olarak MusteriManager kısmında listing methodunu array olarak yaparak,  son olarak method kullanmadan buradan direk arrayi foreach fonksiyonunda kullanarak bastırarak.
             //musteriManager.Listing(musteri1);
             //musteriManager.Listing(musteri2);
             //musteriManager.Listing(musteri3);
            

            //2-)musteriManager.Listing2(musteriler);

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Our Consumers: " + "\n");
                Console.WriteLine("Consumer Id: " + musteri.Id + "\n" + "Consumer Name: " + musteri.Name + "\n" + "Consumer Surname: " + musteri.Surname + "\n" + "Consume age: " + musteri.Age + "\n" + "Consumer Mail: " + musteri.Mail);
                Console.WriteLine("------------------------------------------------------------------");
            }


            //müşteri silme bölümü
             musteriManager.Delete(musteri2);







        }
    }
}
