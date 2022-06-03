using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Do not repeat yourself --> kendini tekrarlama
            //Type Safety --> tip güvenliği = python da bir değişken tanımlandığında başında string veya int gibi veri türlerini belirtmiyoruz ancak c# veya java vb. dillerde bu konu önemlidir buna type safety denir.
            
            string KategoriEtiketi = "Kategori";
            int OgrenciSayisi = 35000; //tam sayıları tutmak için int kullanırız. Sadece int değerleri mi var hayır bu konuda c# kesesi bol, double, float, decimal, vb. var bunların açıklamalarını ödev kısmında yazacağım hepsinin bir karakter sınırı ve byte sınırları bulunur.
            double FaizOrani = 1.45; //yukarıda da bahsettiğim gibi diğer bir sayıları tutmaya yarayan double vardır. Double ondalıklı sayıları tutmaya yarayan bir veri tipidir.
            bool SistemeGirisYapmısMı = false; //boolean veri tipi olarak geçer. true veya false değerlerini alır. true = 1, false = 0 bunu şuradan hatırlayabiliriz kodlama.io sitesinde kullanıcı sisteme giriş yapmış mı yapmamış mı --> eğer girmiş ise true = 1, eğer girmemiş ise false = 0 diyebiliriz yani; 2 durum vardır.Gerçek hayatta burası bir veri kaynağından gelir yani gerçek hayatta bir fonksiyon çalışır sistemegirisyapmismi(); gibisinden.   
            double DolarDun = 7.42;
            double DolarBugun = 7.41;
            /*Not1 = Neden direkt buraya console.writeLine("Kategori"); yazmak varken değişken tanımlıyoruz ? --> console.writeline("Kategori") ifadesini bir sayfa olarak düşünelim bu sayfadan 5 tane olsun patron bize geldi dedi ki kategori değilde sınıflandırma olsun demiş varsayarsak biz her sayfayı gidip düzeltmek zorunda kalacaktık. kendimizi tekrar etmiş olacaktık çünkü her sayfada aynı kod yazıyor bir sayfayı düzelttiğimizde diğer sayfalar da hatalar almaya başlayacaktık. Ancak biz değişken ile tanımladığımızda sadece tanımladığımız değişken üzerinde değişiklik yapmak daha kolay olacaktır.  
            Console.WriteLine("Kategori");

            Console.WriteLine("Kategori");

            Console.WriteLine("Kategori");

            Console.WriteLine("Kategori");

            Console.WriteLine("Kategori");

            yukarıdaki nedene bağlı olarak önemli bir söz "Do not repeat yourself --> kendini tekrar etme bu çok önemli bir olay. yukarıda bir sayfa örneğinde açıkladım.
            */

            //yukarıda bir değişken tanımladık KategoriEtiketi adında şimdi bunu bir ekrana bastıralım. Ekrana bastırırken sadece değişkenin ismini yazmamız yeterlidir.
            Console.WriteLine(KategoriEtiketi);
            //Aslında KategoriEtiketi bir değer tutucudur. Yani takma isim. "Kategori" metni için takma isim diyebiliriz KategoriEtiketi için.
            /* NOT2 = Not1'de ifade ettiğim her biri bir sayfa olarak düşündüğümüzde değiştirmek zor olacak demiştik direk olarak yazsaydık. Ama bir değişkene atanması bize kolaylık sağlayacaktır bir değişiklik durumunda sadece atanmış olan ifadeyi değiştirmek yeterli olacaktır.
            Console.WriteLine(KategoriEtiketi);

            Console.WriteLine(KategoriEtiketi);

            Console.WriteLine(KategoriEtiketi);

            Console.WriteLine(KategoriEtiketi);

            Console.WriteLine(KategoriEtiketi);

            Fark ettiysek, yine bunlarıda birer sayfa olarak düşünelim. burada tırnak içinde "Kategori" yazmıyoruz sadece değişkenin takma olan ismini yazıyoruz bir değişiklik yapacağımızda sadece o değişkene gidip değişiklik yapmak yeterli olacaktır. Ama Not1 de tüm sayfalarda tek tek değişiklik yapmamız gerekecekti.
             */

            //Bir diğer konu ise şart bloklarıdır. Bunlar if-else, switch case, gibilerine diyebiliriz bu şart blokları ne işe yarar. bool veri tipinde bir şeyden bahsettik kullanıcı sisteme girmiş mi girmemiş mi gibisinden eğer(if) kullanıcı sisteme giriş yapmışsa ne olur önüne menüler vs. çıkar işte buna örnek olarak aşağıda belirtelim. 
            //örneğimiz şöyle olsun kullanıcı sisteme başarılı şekilde giriş yaparsa önüne menüler gelsin eğer başarılı şekilde giriş yapamazsa bir uyarı mesajı gelsin.

            if(SistemeGirisYapmısMı == true)//eğer kullanıcı sisteme başarılı şekilde giriş yapamış ise --> true = 1 
            {
                Console.WriteLine("Menuler ve Kullanici Ayarlari Butonu");

            }
            else //eğer sisteme giriş yapamamış ise yani false = 0 ise;
            {
                Console.WriteLine("Lutfen Kullanici Adini veya Sifrenizi tekrar kontrol ediniz!!!");

            }
            //biz aynı pythonda olduğu gibi else if mantığını burada yazabilirdik aynı if-else yapısını şu şekilde de oluşturabilirdik
            /*
             
            if(SistemeGirisYapmısMı == true)
            {
                Console.WriteLine("Menuler ve Kullanici Ayarlari Butonu");

            }

            else if(SistemeGirisYapmısMı == false)
            {

                 Console.WriteLine("Lutfen Kullanici Adini veya Sifrenizi tekrar kontrol ediniz!!!");

            }

            bu şekilde de yazabiliriz.

            --> genellikle iki durum olduğunda işte sisteme girmiş mi, girmemiş mi gibisinden if-else olarak kullanırız ancak 3lü durumlar olduğunda if-else if-else yapısını kullanmamız gerekir. 

            if = eğer, else = değilse

             */

            //pythonda yaptığımız bu dolar bugün dolar dün gibi bir örnek yapmıştık aynı örneği burada da yapalım değişkenlerimizi yukarıda tanımlayalım.
            if (DolarDun > DolarBugun)//eğer doların dünki oranı doların bugünki oranından yüksek ise bana düşmeyi gösteren oku göster.
            {
                Console.WriteLine("Düşüş Oku");
            }
            else if (DolarDun < DolarBugun)//eğer doların dünki oranı bugünki oranından az ise yükselme okunu göster
            {
                Console.WriteLine("Artış Oku");
            }
            else //doların oranları yukarıdaki ikisi gibi değil, dünki oranı ile bugünki oranı eşit ise değişmeyen çizgiyi göster.
            {
                Console.WriteLine("Değişmeyen sabit olan Ok");
            }

            //bir sonraki konumuz döngülerden devam edeceğiz...






        }
    }
}
