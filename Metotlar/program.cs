using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        { //Bugün ki göreceğimiz konu olan metotlar, tekrar tekrar kullanılabilirliği sağlayan kod bloklarıdır. "Do not repeat yourself" --> için önemlidir. çünkü bir kodu (metot kullanımları hariç olan düz yazılmış kod) farklı farklı sayfalarda yazarsak aynı kodu herhangi bir değişim talebi geldiğinde sayfaların hepsinde güncelleme yapmamızı gerektirecektir. bu şekilde yapmaktansa bu tekrar edeceğimiz kodları bir method haline getirdikten sonra kullanım hem değişim talebini daha kolaylık sağlayacaktır hem de clean code mantığına uygunluk olacaktır.
          //Do not repeat yourself - Clean Code - Best Practise
          //metodlardan nasıl yararlanıyoruz örneğin bir e ticaret sitesi düşünelim siteye girdiğimizde bir buton karşımıza çıkar sepete ekle tarzında. bu buton farklı sayfalarda hatta mail yolu ile de karşımıza çıkıyor tahmin edersiniz ki butonun arkasında da kod bloğu vardır. ve eğer programcı bu kod bloğunu her zaman farklı farklı şekilde kullansaydı ufak bir değişiklikte kendisini sürekli değiştirmek zorunda kalacktı bunu 10 satırlık kod ile düşünmemek gerekiyor 1000 satırlık bir kod içerisinden değiştirmeyi düşünmek gerekiyor. işte sürekli kendini tekrarlamak zorunda kalacak bundan dolayı biz methodlardan yararlanıyoruz.  
          //Classları ise biz neden kullanıyoruz; şimdi bir ürün düşünelim ürün olması için string adı, int fiyatı, string özellikleri vb. olması gerekmektedir. Ürün adı sadece tek başına ürünün adını anlatır, fiyatı tek başına ürünün fiyatını anlatır ancak 3ü beraber(adı, fiyatı, özellikleri) ürünün kendisini oluşturur. işte biz de class yapısını ürünün string adı, int fiyatı, string özellikleri üçünü beraber tutan bir yapı olduğundan dolayı kullanırız. (*class yapısı farklı veri tiplerini bir arada tutabilmeye yarayan bir yapı diyebiliriz.)

            /* NOT = Neden ürün tanımlamak için class yapıyoruz tek tek de atayabilirdik dersek şimdi bunun cevabını aşağıda yapacağımız bir örnekle cevaplayalım

              string urunAdi1 = "Elma";
              int fiyati1 = 15;
              string Aciklama1 = "Amasya Elmasi";

              string urunAdi2 = "Portakal";
              int fiyati2 = 10;
              string Aciklama2 = "Finike portakalı";
                    .
                    .
                    .
              şimdi biz bu şekilde tek tek atayarak ürünlerimizi oluşturduğumuzu düşünelim. manava bir program yazıyoruz ve yeni meyveler geldikçe tek tek ekliyoruz.
              bu ürünleri bir arraya koymak istesek aslında 2 tane ürünümüz var bu 2 ürünü bir diziye koyamayız hangi birini nereye koyacağız böyle bir problem var mesela string[] meyvele = new string[]{"Elma", "Portakal"} bu şekilde bir dizi oluşturduğumuzda sadece string değerlerini girmiş oluyoruz ancak ürünün ürün olması için adı, fiyatı ve açıklaması gerekmektedir diğerlerini array içine alamıyoruz işte bundan dolayı class kullanıyoruz.   

              biz bunları tek tek atayarak yapamadık şimdi aşağıda Urun classımızda oluşturduğumuz ürün özelliklerini atayarak bir kaç ürün oluşturalım (adi, fiyati ve açıklaması ile birlikte)
             */


               Urun urun1 = new Urun(); //bir class tanımlamamız için bunu yapmamız gerekiyor buna örnek deniliyor, class'ın örneği. --> bu hareket yukarıda string urunAdi yazdık aslında string genel bir tanımdır ancak yanına string urunAdi yazınca ona bir örnek oluşturuyoruz yani string türünde bir şey oluşturmuşuz veya string türünde başka bir şey oluşturmuşuz string aciklama gibisinden.  (aslında bu işlemi değişken tanımlıyoruz gibi düşünebilirsin string isim = "taha"; string tipinde bir isim oluşturdun aynı şekilde Urun tipinde urun1 oluşturdun. diyebiliriz)(new mantığına ileride değineceğiz) 
                urun1.Adi = "Elma";
                urun1.Fiyati = 15;
                urun1.Aciklama = "Amasya Elmasi";


               Urun urun2 = new Urun();
                urun2.Adi = "Karpuz";
                urun2.Fiyati = 80;
                urun2.Aciklama = "Diyarbakır Karpuzu";

            //yukarıda tek tek atadığımız ve birbirinden bağımsız yapıyı class sayesinde bir düzene sokmuş olduk birbiriyle bağlantılı yani ürünü oluşturan özellikleri bir düzen içinde atamasını yaptık.
            //yukarıda tek tek atadığımız ürünleri bir array içine alamadık. şimdi class yapısı sayesinde bir array oluşturalım bakalım burada array içine alabilecek miyiz. Biz nasıl yukarıda string array oluşturabildiysek burada da Urun arrayi oluşturabilriiz.

            Urun[] urunler = new Urun[] {urun1, urun2};

            //array ne demekti = bir veri tipinde istediğimiz kadar datayı yani ne kadar data eklersen o datayı tutan yapıydı.
            //gerçek hayatta biz arrayi kendi elimizle oluşturmayız data bir veri kaynağından gelir.
            //array yapmamızın diğer bir sebebi ise bu ürünlerimizi ekrana bastırırken döngü metodunu kullanmak.

            foreach (Urun urun in urunler) //bu yapıyı daha önceki derslerde açıklamıştık. Urun --> veri tipi, urun --> takma ad, in urunler --> urunler dizimizin elemanlarını tek tek gez anlamındadır.
            {
                Console.WriteLine("Urun Adi: " + urun.Adi + "\n" + "Urun Fiyati: " + urun.Fiyati + "\n" + "Urun Ozelliği: " + urun.Aciklama);
                Console.WriteLine("---------------------------------------");
            }



            /*
                Not = Classlar ile ilgili aslında 2 temel kullanım vardır;
            1-) Classlar yukarıdaki yaptığımız gibi özellik tutuyorlar. Bundan dolayı biz Urun class'ı oluşturduk, Urunlerin bilgilerini, ozelliklerini tutsun diye(ürün adi, fiyati, açıklaması). veya müşteri classı oluştursaydık, müşteri adi, soyadi, tcsi gibi şeyler olacaktı. //Property-Özellik deniliyor buna hatta prop fonksiyonu buradan geliyor.
            Ayrıca biz Urun class'ı içine yani ürüne Id ekledik --> Id = bir datayı diğerlerinden ayırt etmek için kullandığımzı eşsiz değeri anlatır. yani tc kimlik no gibi. türkiyede birden fazla taha adıyaman olabilir ancak beni diğerlerinden ayıran tc kimlik numaramdır. 
            tc kimlik no gibi alanlar olsada biz Id vermekten vazgeçmeyiz.

            2-) Classların diğer bir kullanım şeklide bu dersin başında oluşturduğumuz sepetmanager.
            bu tarz manager, service, doll, data access, controller gibi ifadeler görürsek bunlar bir operasyon tutuyor demektir.
            metodları hatıralayalım şimdi yukarıda bahsetmiştik(fonksiyonlar-tekrar tekrar kullanım) bu tarz ortak kodlarımızı yani metodlarımızı classlarımızın içine yazarız. 
            örneğin yukarıda da bahsettiğimiz bir alışveriş sisteminde bir sepete ekleme butonunu düşünelim; sepete ekleme, sepeti gösterme, listeleme gibi işleri metod olarak grublandırırız. sepet ile ilgili işemler, müşteri ile ilgili işlemler, ürün ile ilgili işlemler 
            şimdi sepetmanage.cs' e geçiyoruz oradan devam edeceğiz.
            */

            Console.WriteLine("------Metotlar------");
            //şimdi sepetmanager.cs den buraya geldik orada oluşturduğumuz Ekle metodunu burada çağıracağız.
            //oluşturduğumuz metodu çağırmamız için ilk önce sepetmanager class ımızı buraya çağırmamız gerekecek yani burada bir örneğini oluşturmamız gerekecek bunun nedeni biz metodumuzu sepetmanager classı içine yazdığımız için ilk önce classı burada tanımlayacağız daha sonra metodumuzu çağıracağız.

            //aşağıda yaptığımız örnekleme hareketi --> instance(örnekleme)
            SepetManager sepetManager = new SepetManager(); //burada SepetManager classımızın bir örneğini oluşturduk isimleri aynı değil birisi SepetManager buradaki örnek sepetManager. --> bu işlem de yukarıda string tipinde isim gibi değişken tanımlamamız veya Urun tipinde urun1 tanımlamamız gibidir.
            //şimdi classımızı tanımladık artık sıra metodumuzu çağırmakta bu da aynı urun1.adi gibi çağırıyoruz. nedeni aynı mantık ikiside class içinde olan yapıyı çağırıyoruz.
            //sepetManager.Ekle(); //metodumuzu çağırmış bulunduk.
            
            /*yukarıda anlattığımız sepete ekle mantığını aşağıda sepetManager.Ekle() 5 ayrı sayfada  olarak düşünelim ve simüle edelim
            sepetManager.Ekle();
            sepetManager.Ekle();
            sepetManager.Ekle();
            sepetManager.Ekle();
            metod bana ne imkanı vermiş oldu revisubility yani metod bana tekrar tekrar kullanabilme imkanı verdi.
            eğer bir değişiklik durumunda SepetManager.cs  e gidip oradan değişikliğimizi rahatça yapabiliriz ve daha sonra bütün sayfalar aynı anda değişikliği gerçekleştirmiş oldu eğer biz bunu metot ile değil tek tek yapsaydık büyük ihtimal sayfanın birini değiştirirken diğer sayfa yanıt vermiyor veya değişmemiş olacaktı.  
            */

            //şimdi biz burada basit bir fonksiyon ile bunları yaptık şimdi SepetManager.cs ye geçip farklı bir şeyden daha bahsedeceğim.
            //SepetManager classımızda metodumuza bir parametre atadık ürün adında artık burada metodumuzu çağırdığımızda parantez içine bir ürün eklememiz gerekiyor yoksa metodumuz altı çizili kırmızı olacaktır.
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            //SepetManager.cs de oluşturduğumuz ekle2 metodumuzu çağıralım.

            sepetManager.Ekle2("Armut", "Yeşil Armut", 25, 35);
            sepetManager.Ekle2("Elma", "Sarı Elma", 12, 24);
            sepetManager.Ekle2("Çilek", "Kırmızı Çilek", 35, 14);
            //Ekle2 fonksiyonunda istenilen parametreleri yazdığımızda o metoda gidiyor ve süslü parantezler içinde istenilen kod çalışıyor ancak bu yanlış bir yöntemdir bunun sebebi ise;
            //şimdi bunuda bir programcının sayfa simülasyon mantığı ile kullandığını düşünelim.
            //ürünleri biz bu şekilde de sepete ekleyebilirdik neden illa parametrelerimizi class olarak belirliyoruz ? -->  3 tane sayfa olarak düşünelim bunu; 3 farkı sayfada ekle2 metodunu çağrdık çünkü aynı şeyi yapıyorum. Sonra yönetim dedi ki biz ürünün adını, fiyatını, açıklamasını giriyoruz bir de stokadetini girelim dediler.
            //şimdi SepetManager.cs ye gidelim Ekle2 metodumuza bir yeni parametre daha ekleyelim int stokAdeti diye hemen yapalım.
            //Ekle2 metodumuza yeni parametremizi ekledik int stokAdeti diye ancak yukarıda gördüğümüz üzere metodun altı kırmızı çizgi oldu yani bize kızdı. Yani tüm sayfalar eror verdi. Bu sayfalarda eroru gidermek için şimdi Şimdi bu 3 farklı sayfada ekle2 metodumuza tek tek stokAdetini de ekleyeceğiz ki metodun kuralına uyalım belirttiğimiz parametrelerin hepsini yazalım ki metod doğru çalışsın şimdi tek tek sayfalara gideceğiz ve stokAdeti parametresini de gireceğiz..
            //Ama biz bu stokAdetini class parametresine eklediğimiz zaman Urun.cs e gideriz oraya yeni bir prop yaparak stokAdeti özelliğini ekleriz ve sonucunda Ekle metoduna class parametresine urunu eklediğimiz zaman artık bu özelliğide otomatik olarak dahil etmiş olduk. Şimdi program.cs ye döndüğümüzde class parametresi ile çağırdığımız Ekle metodunu çağırdığımız farklı sayfaların hiç biri eror vermemiş oldu. --> buna encapsulation deniliyor.
            //Encapsulation --> Ekle2 metodu gibi ayrı ayrı yacağımız parametreleri düzensiz olacak şekilde yazmak yerine, bunları bir düzene sokup bir kapsülün(class ürün) içinde yazarak bir düzene sokma işlemine denir.
        }
    }
}


