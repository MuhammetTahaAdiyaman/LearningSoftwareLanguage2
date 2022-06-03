using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {//burada şunu yapalım sepete ürün ekleme işlemini yapabiliriz.
     //bir metod-fonksiyon şu şekilde yazılır (c++ dan hatırlayacağımız void fonksiyonu ve diğer fonksiyonlar gibi)
        //naming convention--> kodun okunurluğu için doğru yazma teknikleri ilk harf büyük olacak.
        //eğer bir yerde normal parantez görürsek anlayalım ki orada bir method-fonksiyon çalışıyor(c# ve java için geçerlidir.)
        /*public void Ekle()
        {

            Console.WriteLine("Sepete Eklendi"); //bu metodun yapacağı işlem bu süslü parantezler içine yazılır.
            //süslü parantez içinde bir satırlık kod da olabilir 100 satırlık kod da olabilir biz program.cs de bu Ekle metodunu çağırında bu süslü parantez içi defalarca çağrılabilir. Şimdi bunu program.cs de bir çağıralım.
        }
        */
        //şimdi bir eticaret sitesi düşünelim ürünler sıralanıyor 3 tane ve sepete ekle butonu var ben ilk baştaki ürünü almak istiyorum ya bundan dolayı "bana ne ekleyeceğimi söyle" demem gerekiyor programcı olarak. bir gerçek e ticaret sisteminde sadece ekle metodunu çağırsam bir anlamı yok. benim neyi eklemek istediğimi metoda vermem gerekiyor işte buna parametre deniliyor. Biz ne ekleyeceğiz ürün şimdi aşağıda fonksiyonda gösterelim.
        public void Ekle(Urun urun) //Urun --> veri tipi, urun --> metodu kullanırken vereceğimiz isimlendirmedir.
        {

            Console.WriteLine("Sepete Eklendi: " + urun.Adi); //artık parametre olarak urun belirlediğimiz için burada urun ile alakalı her şeye ulaşabiliriz.

        }

        //şimdi bir tane daha method yazalım ve bunlara parametrelerini tek tek atayalım.

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdeti) //biz bu şekilde de yazabilirdik ancak bu yanlış bir tercih yoludur sebebini program.cs de açıklayacağım.
        {

            Console.WriteLine("Sepete Eklendi: " + urunAdi); //buradan urun.Adi şeklinde eklemedik çünkü yukarıda fonksiyonda biz urun classını parametreye atamıştık ancak burada parametreyi direkt olarak kendimiz tek tek atayacağımız için bu şekilde yazdık.
        } 
        //şimdi bu Ekle2 metodunu neden yanlış olduğunu açıklayalım. program.cs de.
    }
}
