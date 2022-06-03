using System;
using System.Collections.Generic;
using System.Text;

namespace Odev2MusteriTakibi
{
    class MusteriManager
    {


        public void Add (Musteri musteri)
        {
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Consumer Name: " + musteri.Name + "\n" + "Consumer Surname: " + musteri.Surname + "\n" + "**added to list**");
            Console.WriteLine("------------------------------------------------------------------");

        }

        public void Listing (Musteri musteri) //listeleme yöntemini direk methoda array üzerinden de ulaşabilirdik. aşağıda örneğini göstereceğim
        {
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Our Consumers: " + "\n");
            Console.WriteLine("Consumer Id: " + musteri.Id + "\n" + "Consumer Name: " + musteri.Name + "\n" + "Consumer Surname: " + musteri.Surname + "\n" + "Consume age: " + musteri.Age + "\n" + "Consumer Mail: " + musteri.Mail);
            Console.WriteLine("------------------------------------------------------------------");

        }


        public void Listing2(Musteri[] musteriler) //Bu şekilde direkt olarak method olarak array kurabiliriz burada parametre olarak Musteri classının arrayını yapıyoruz ve takma ad aşağıda kullandığımız foreach fonksiyonu içinde geçerli olacak.
        {
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Our Consumers: " + "\n");
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Consumer Id: " + musteri.Id + "\n" + "Consumer Name: " + musteri.Name + "\n" + "Consumer Surname: " + musteri.Surname + "\n" + "Consume age: " + musteri.Age + "\n" + "Consumer Mail: " + musteri.Mail);

            }
            Console.WriteLine("------------------------------------------------------------------");

        }


        public void Delete (Musteri musteri)
        {
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Consumer Name: " + musteri.Name + "\n" + "Consumer Surname: " + musteri.Surname + "\n" + "**deeted to list**");
            Console.WriteLine("------------------------------------------------------------------");

        }

    }
}
