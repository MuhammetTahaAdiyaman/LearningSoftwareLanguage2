using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Burada anlatacağımız konu class yapısıdır. Şimdi öncelikle class mantığı nedir ve niçin kullanırız bundan azıcık bahsedelim 3.gün videosunda ayrıntılı olarak göreceğiz zaten
            //Örneğin kodlama.io ya girdiğimizde bir kursa bakalım kursun adı, imajı, kurshocası, yüzdelik kısmı var bu özelliklerin hepsi bir kursu oluşturuyor işte biz class yapısını bunun için kullanıyoruz class içinde bir den fazla ve farklı veri tipleri (string int double) ile özellikler oluşturabiliriz.
            //şimdi bir örnek üzerinden anlatınca daha iyi anlayabiileceğiz kodlama.io da olan kursları class mantığı ile yapalım.

            Kurs kurs1 = new Kurs(); //biz aşağıda belirlediğimiz kurs classımızı burada kullanabilmemiz için ilk önce tanımlamamız gerekiyor ve bu şekilde tanımlatıyoruz new ileride mantığını anlayacağız.
            //artık bu tanımlattığımız kurs1'e class yapısı içinde oluşturduğumuz özellikleri atayalım kurs1.gereken özellikleri atayabiliyoruz
            //kurs1 imiz var tipi Class Kurs, aynı şu mantıkla düşünebiliriz bir önceki kurs da da kurslarımız vardı orada tipi stringdi --> string kurs1
            kurs1.kursAdi = "Yazilim Geliştirici Yetiştirme Kampi"; //string olarak belirttiğimiz için burada tırnak içinde yazıyoruz.
            kurs1.Egitmen = "Engin Demirog";//string
            kurs1.IzlenmeOrani = 86;//int

            //şimdi yukarıda yaptığımız aynı mantık ile 2.kursumuzu oluşturalım yani buradan anladığımız şu nasıl string a, string b gibi birden fazla string değişkeni kullanabiliyorsak birden fazla class Kurs değişkeni de kullanabilirz.

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "Programlamaya giris için kurs";//string
            kurs2.Egitmen = "Taha Adiyaman";//string
            kurs2.IzlenmeOrani = 35;//int

            //yine yukarıdaki gibi 3.kursumuzu ekleyelim

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "c#  giris için kurs";//string
            kurs3.Egitmen = "Ahmet Vural";//string
            kurs3.IzlenmeOrani = 42;//int

            //burada 3 tane kurs tanımladık bundan önce sadece tek bir string ile adını tanımlarken şimdi kursun çeşitli özelliklerini class yapısı sayesinde tanımladık.
            //Peki biz bunları ekrana nasıl bastıracağız burada da aynı console.writeLine ile bastıracağız class olduğu için kurs1.kursAdi gibi aşağıda gösterelim.
            Console.WriteLine(kurs1.kursAdi + " : " + kurs1.Egitmen + " : " + kurs1.IzlenmeOrani); //bu şekilde ekrana bastırabiliriz.
            //evet biz tüm kursları alt alta bu şekilde bastırabiliriz.
            //ancak bu bir dinamik değil bunu dinamikleştirmek için önceki derslerimizde öğrendiğimiz bilgileri burada tekrar edeceğiz class yapımızı ekrana bastırmak için bu 3 kursumuzu öncelikle array-dizi haline getirip daha sorna döngü ile basacağız 
            Console.WriteLine("****dinamik***");
            //ilk önce yukarıda tanımladığımız kursları array haline getirelim.

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 }; //aynı bir önceki derste gördüğümüz string değişkeninde oluşturduğumuz kursları string arrayi burada class Kurs değişkeninde aynı mantık ile arrayi oluşturabiliriz. yani burada string yerine clasını oluşturduğumuz Kurs değişkenimizi yazacağız.
            //string[] kurslar = new string[] {}; --> bu şekilde yazarsak array içinde yalnızca string verileri tutabiliriz ancak yukarıda ki gibi yazarsak bir çok değişkeni, veriyi tutabiliriz çünkü class yapısı olduğu için.
            //şimdi kurslarımızı array şeklinde yazdık sıra geldi döngü ile ekrana bastırma işlemi array olduğu için foreach ile bastıralım ilk önce daha sonra for ile de bastırabiliriz örnek çeşitliliği açısından iyi olur.

            foreach (Kurs kurs in kurslar) //Kurs --> veri tipi (class), kurs --> takma ad, in kurslar --> kurslar adında arrayi dön demek kaç kurs varsa o kadar dönecek (içine atadığımız özellikleri ile)
            {
                Console.WriteLine(kurs.kursAdi + "\n" + kurs.Egitmen + "\n" + kurs.IzlenmeOrani);
            }
            //console.writeLine(kurs.kursAdi) gibi yazdık neden kurs.kursAdi da kurs1 veya kurs2 yazmadık çünkü tüm kursları dönecek bundan dolayı kurs1 vs. yazmıyoruz

            //eğer for ile döndürmek istersek bazı farkları var demiştik özellikle i konusunda onuda burada görmüş olalım
            Console.WriteLine("for döngüsü");
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i].kursAdi + "\n" + kurslar[i].Egitmen + "\n" + kurslar[i].IzlenmeOrani);
            }
            //for ile foreach temel farkları şartı belirlerken foreach --> in kurslar, for --> kurslar.length
            //***ikinci bir fark ise ekrana bastırırken foreach --> sadece takma ad ile işlemleri yaparız --> console.writeLine(kurs.kursAdi), for --> ekrana bastırırken array ismi ile ekrana bastırırız ve array ismine i ekleriz i = sayaç --> console.writeLine(kurslar[i].kursAdi)


        }
    }

    class Kurs //bunun mantığını şu şekilde anlayabiliriz daha önce bir string tanımlıyorduk string adı = "engin" gibi vb. aynı şekilde class da string gibi veri türüdür yukarıda biz Kurs kurs1 değişkenini tanımlayacağız nasıl string isim, int numara gibi değişken tanımladıysak Kurs kurs1 gibi değişken de tanımlayabileceğiz.
    {//class içine oluşturacağımız objenin özelliklerini eklemek için "prop" (tab tab) (proporty) kodunu kullanacağız burada özellikleri belirleyeceğiz yukarıda bu özelliklere atamalar yapacağız.
        public string kursAdi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }

    }//class ile birlikte sadece string sadece int değil 3 özelliği birden tutan bir kurs tanımladık aslında classların kullanma amacımız da budur. içinde farklı farklı değişkenleri bir arada tutmasını sağladığı için.
}







/*              -ÖDEVLER- 2.GUN
 
Soru1: C# dilinde bulunan diğer veri tipleri nelerdir? (Ezberlemeyiniz, sadece araştırıp inceleyiniz.)

Cevap:
sbyte	1 Byte	 işaretli tamsayı	-128  ile 127
short	2 Byte	işaretli tamsayı	-32.768 ile 32.767
int	    4 Byte	işaretli tamsayı	-2.147.483.648 ile 2.147.483.647
long	8 Byte	işaretli tamsayı	-9.223.372.036.854.775.808 ile9.223.372.036.854.775.807
byte	1 Byte	işaretsiz tamsayı	0 ile 255
ushort	2 Byte	işaretsiz tamsayı	0 ile 65.535
uint	4 Byte	işaretsiz tamsayı	0 ile 4.294.967.295
ulong	8 Byte	işaretsiz tamsayı	0 ile 18.446.744.073.709.551.615
float	4 Byte	tek kayan sayı	+yada – 1,5*10-45 : + ya da – 3,4*1038
double	8 Byte	çift kayan sayı	+yada – 5*10-324 : + ya da – 1,7*10308
decimal	16 Byte	ondalıklı sayı	+yada – 1,5*10-28 : + ya da – 7,9*1028
bool	——-	——	true ya da false
char	2 Byte	Unicode karakterler	U + u + ffff 0000

****************************************************************************************************************************

Soru2: C# dilinde "ternary operatörü" araştırınız. Ternary Operatörü bilmeyen birine yazıyla anlatmanız gerekseydi, nasıl anlatırdınız?

Cevap: 
Fazla kod yazmamızı engeller daha az satırla işlemlerimizi yapmamızı sağlar. 
Bool türünden koşulu belirtiyoruz sonra eğer koşul doğruysa yapılacak işlemler için ? ,eğer koşul yanlış yani sağlanmıyor ise : koyuyor ve ardından yapılacak işlemleri, kodları yazıyoruz. 
Mantığı If-Else e benzer ancak kod okunabilirliğini azalttığı için birden fazla koşul durumunda kullanılması önerilmez.

Örnek;Tek satırda koşul bloğudur. 

Eğer a sayısı 5 ise ekrana "beş" yaz, değilse "beş değil" yaz ifadesinin kodlanmış hali;

string besmiDegilmi= (a == 5 ? "sayı beş" : "sayı beş değil");

****************************************************************************************************************************

Soru3: C# dilinde "switch" yapısını araştırınız. Switch yapısını bilmeyen birine yazıyla anlatmanız gerekseydi, nasıl anlatırdınız?

Cevap:
If-else e benzeyen şart bloğudur. If else ile yapılacak işlemlerin karmaşık veya fazla olduğu durumlarda daha sade ve anlaşılır bir kod yapısı oluşturmak için kullanılır. Her bir sonuç için bir case oluşturulur. Hangi durum doğruysa, sağlanıyorsa o case çalışır. Hiç bir durum doğru değil ise default çalışır Switch case ile yapılan her şey if else ile yapılabilir ancak if else ile yapılan her şey switch case ile yapılamaz.

Örneğin girilen sayının hangi ayı ifade ettiğini switch ile yapalım:
int sayi;
switch(sayi)
{ case 1: 
    Console.WriteLine("Ocak");
    break;
case2: 
    Console.WriteLine("Şubat");
    break;
case 3: 
    Console.WriteLine("Mart");
    break;
case 4: 
    Console.WriteLine("Nisan");
    break;
case 5: 
    Console.WriteLine("Mayıs");
    break;
case 6: 
    Console.WriteLine("Haziran");
    break;
case 7: 
    Console.WriteLine("Temmuz");
    break;
case 8: 
    Console.WriteLine("Ağustos");
    break;
case 9: 
    Console.WriteLine("Eylül");
    break;
case 10: 
    Console.WriteLine("Ekim");
    break;
case 11: 
    Console.WriteLine("Kasım");
    break;
case 12: 
    Console.WriteLine("Aralık");
    break;
default: 
Console.WriteLine("1 ile 12 aralığında bir değer giriniz!");
break;
}

****************************************************************************************************************************

Soru4: C# dilinde "while döngüsünü" araştırınız. While döngüsünü bilmeyen birine yazıyla anlatmanız gerekseydi, nasıl anlatırdınız?

Cevap: 
while ile tanımlanan koşul sağlandığı sürece döngü içerisindeki kodlar çalışır.Döngüye girerken ve döngü her tekrarlandığında koşulun sağlanıp sağlanmadığı kontrol edilir.Buna göre döngü çalışmaya devam eder veya sonlanır.Koşul sağlanmıyorsa hiç çalıştırılmadan döngüden sonraki kısma geçilir. 

int sayi=0;
while(sayi<=10) //döngü sayi 10dan küçükse ve 10a eşit olana kadar çalışacak. sayı 11 olduğunda döngüye girilmez
{Console.WriteLine(sayi);
sayi++; //Her çalıştığında sayı bir arttırılacak
}

****************************************************************************************************************************

Soru5: Herhangi bir e-ticaret sistemine giriniz.

Genellikle bir e-ticaret sistemine girdiğinizde ürünler listelenir. Siz de Urun (Product) isimli bir class oluşturup, oluşturduğunuz bir kaç ürünü bir diziye ekleyiniz.

Ürünlerinizi for, foreach ve while döngüleri ile ayrı ayrı listeleyiniz.

Exmple: 

Using System;

namespace ClassIntro
{
    class Program
    {
        Static void Main()
        {
         
            Console.WriteLine("HepsiBurada'ya Hosgeldiniz");
            Console.WriteLine("Urunler");
            
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Xiaomi Note 9s";
            urun1.UrunFiyati = 3200;
            urun1.UrunOzellik = "Android 4.0";
        

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Ariel Çamaşır Suyu";
            urun2.UrunFiyati = 40;
            urun2.UrunOzellik = "Dikkat! ölüm riski barındırır";
            
            Urun urun2 = new Urun();
            urun2.UrunAdi = "Monster Notebook";
            urun2.UrunFiyati = 6999;
            urun2.UrunOzellik = "i7, 16gb ram";

            //bunları ekrana bastırmak için ilk önce arrayi oluşturmamiz gerekecek;
            
            Urun[] urunler = new Urun[] {urun1, urun2, urun3}

            //Şimdi tüm döngülerle bunu ekrana bastırmaya çalışalım. İlk önce foreach fonksiyonu ile

              foreach(Urun urun in urunler)
              {
                
                   Console.WriteLine("Urun Adi: " + urun.UrunAdi + "\n" + "Urun Fiyati: " + urun.UrunFiyati + "\n" + "Urun Özelliği: " + urun.UrunOzellik);

              }
            
            // şimdi for döngüsü ile

               for(int i=0; i<urunler.Length; i++)
               {


                    Console.WriteLine("Urun Adi: " + urunler[i].UrunAdi + "\n" + "Urun Fiyati: " + urunler[i].UrunFiyati + "\n" + "Urun Ozelliği: " + urunler[i].UrunOzellik);


               }
                
               // şimdi while döngüsü ile

                  int i = 0;
                  while(i<kurslar.Length)
                  {

                     Console.WriteLine("Urun Adi: " + urunler[i].UrunAdi + "\n" + "Urun Fiyati: " + urunler[i].UrunFiyati + "\n" + "Urun Ozelliği: " + urunler[i].UrunOzellik);
                     i++;

                  }

        }
       
    }
    

    class Urun
    {
        public string UrunAdi {get; set;}
        
        public int UrunFiyati {get; set;}
        
        public string UrunOzellik {get; set;}
    }
}


 */
