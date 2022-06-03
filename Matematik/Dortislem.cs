using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        
        public void Topla(int sayi1, int sayi2)//iki tane sayıyı toplayacağımızı varsayarsak, bu parametre kısmı metodumuzun ihtiyacı olanları aslında. Toplama yapabilmek için 2 tane sayıya ihtiyacım var sepete ekleyebilmek için bir tane ürüne ihtiyacım var. Dolayısıyla buraya iki tane parametre ekleyelim sayi1 ve sayi2 adında. 
        {//Topla metodunu kullanabilmem için, çağırabilmem için bizim bu metoda iki tane sayı vermemiz gerekmektedir anlamına gelir.

            int toplam = sayi1 + sayi2; //önce eşitliğin sağ tarafı çalışır sayi1 ve sayi2 toplanır int toplama atar.
            Console.WriteLine("Sonuc: " + toplam);
            //bunu program.cs de şu şekilde çağıracağız aslında Topla(10,35) --> aslında sayi1 = 10, sayi2 = 35
            //şimdi bu metodu program.cs de çağıralım.
        }

    }
}
