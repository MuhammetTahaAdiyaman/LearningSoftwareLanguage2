using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {//Bu derste List diye bir şey olmasaydı bu koleksiyonu kendimiz nasıl oluşturabilirdik bunun üzerinde duracağız. Bundan dolayı ilk önce bir class ekleyelim.
         //şimdi classımızı buraya çağıralım ilk önce;
         //MyList isimler = new MyList(); //biz classlarımızı bu şekilde kullanabiliriz ancak List yapısında olduğu gibi <> bu işaret ile kullanmak istiyorsak ne yapabilirz. Bunun için MyList class sayfamıza geçelim ve oradan devam edelim.
         //gördüğümüz üzere yukarıda MyList altları kırmızı olmuş. Burada ne demek istiyor --> sen beni bu şekilde kullandın ama ben generic bir class'ım içerisinde olan metodlar tip bağımlı çalışıyor vereceğin tipe göre oluşturacağım ben onları o yüzden lütfen çalışacağın veri tipini söyle bana diyor. Bundan dolayı çalışacağımız veri tipi ile birlikte yazalım aşağıda; yukarıdakini yorum satırına alacağım yorum satırını silince kırmızı olduğunu göreceksin.

            MyList<string> isimler = new MyList<string>();
            //şimdi Add fonksiyonumuzu çağıralım;
            isimler.Add("Engin"); //bu Add metodumuz için string yazacağız çünkü yukarıda çalışacağımız veri tipini string olarak belirledik.
            //biz bu Add metodunu oluşturduk ama bunu bir yere eklemiyor tamam ismi Add ama hafızada tutacak bir şey yok List mantığında olduğu gibi yapmamız gerekli nasıl yaparız ? şimdi gidelim MyList.cs ye oradan devam edelim. 17.satırdan.

            
        }
    }
}
