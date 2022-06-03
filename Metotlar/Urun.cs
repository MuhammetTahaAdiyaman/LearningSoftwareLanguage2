using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Urun
    {//bizim için bir ürünün ürün olabilmesi için çeşitli özellikleri barındırması gerekir. Nasıl string de bir metin tutuyorsak, nasıl int de tam sayı tutuyorsak, nasıl double da ondalıklı sayı tutuyorsak, class içinde de birden fazla farklı veya farklı olmayan veri tiplerini tutabiliriz.
     //bu classımız ürün classıdır. burada ürün oluşturmak için çeşitli ürün özellikleri oluşturacağız(prop ile) daha sobra program.cs de bu özelliklere değerler atayacağız.
     //Property deniliyor buna hatta prop fonksiyonu buradan geliyor. --> bu classlarımızın ilk kullanım şeklidir.
        public int Id { get; set; }

        public string Adi { get; set; }

        public int Fiyati { get; set; }

        public string Aciklama { get; set; }

        public int StokAdeti { get; set; }

        //class dediğimiz olay aslında string, int gibi tek bir bilgiyi değilde, o nesneyi tanımlayan birden fazla bilgi varsa bunları class içinde barındıran bir yapıdır.

    }
}
