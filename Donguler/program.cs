using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //burada ki konumuz ise döngüler(loop). Döngüleri biz birbirine benzeyen işlemleri tekrar etmek için kullanırız.Döngülere örnek olarak for, foreach(genellikle array), while döngüleri vardır.
            //ilk olarak göreceğimiz döngü olan for ile başlayalım.
            for (int i = 1; i < 10; i++) //burada bazı şeyler var onları açıklayalım. int i = 0 --> başlangıç değeri, i<length--> şartımız ve bu döngü bu şart geçerli olduğu sürece çalışır.(örnek olarak 1 den başla 10a kadar sayıları sırala derken 10a kadar olan yerdir.), i++ --> her seferinde i'yi bir bir arttır demek. i--> sayaç anlamına gelir aslında döngümüzü bununla kontrol ediyoruz diyebiliriz.
            {//yukarıda parantez içine yazdığımızın anlamı ise 1 den başlar, 10 a kadar, birer birer arttırarak bas.
                Console.WriteLine(i);
            }

            Console.WriteLine("*****************************");

            //eğer biz i'yi ikişer ikişer arttır deseydik o zaman; i = i+2 diyebiliriz örnek olarak gösterelim aşağıda
            for (int i = 1; i < 10; i = i+2)
            {
                Console.WriteLine(i);
            }

            /*
            Not = yukarıda i++ yazdık aşağıda i = i+2 yazdık şimdi şunu söyleyelim biz arttırma ifadelerini farklı şekillerde yazabiliriz aşağıda belirtelim.

            i++ --> i = i+1 --> i+=1 ifadelerinin hepsi aynı anlama gelmektedir.

            i = i+2 --> i+=2 --> bu ifadeler de aynı anlama gelmektedir.

            */

            Console.WriteLine("*****************************");
            //Array-dizi
            //şimdi diziler(array)-liste mantığına bakalım çünkü döngüler ile listelerin ortak bir bağı var açıklayacağım sonunda.
            //Neden dizi(array) kullanıyoruz, dizi(array) nedir dersek açıklayalım aşağıda.
            //Kodlama.io sitesine baktığımızda kurslar var ve biz bu kursları değişken atayarak yazalım öncelikle;

            string Kurs1 = "Yazilim Gelistirici Yetistirme Kampi";
            string Kurs2 = "Programlamaya Baslangic Icin Kurs";
            string Kurs3 = "Java";

            //Bu kurslara ek olarak yeni ürünler ekleniyor ve ürünlerin sayısı hiç bir zaman sabit kalmıyor, eticaret sitelerinde binlerce ürün var hepsini tek tek tanımlayamayız eğer biz sürekli bu şekilde yaparsak bunun sonu hiç gelmez ve çok çok uğraştırı bunun yerine biz bu kursları ekranda dinamik olarak yerleştirmemiz lazım bunu biz array(dizi)-liste yöntemi ile yapacağız
            //Bu tarz liste formatında göstermek istediğimiz verileri string int gibi değişkenlerde değilde dizilerde(array) tutarız. 
            //Şimdi bir dizi nasıl tanımlanır ? yukarıdaki kursları bir dizi içinde tanımlayalım bakalım.
            string[] kurslar = new string[] {"Yazilim Gelistirici Yetistirme Kampi", "Programlamaya Baslangic Icin Kurs", "Java", "Python" }; //bunun anlamı şu ben tek bir stringi değil birden fazla stringi aynda anda tutmak istiyorum bundan dolayı çoğul ifade kullanıyoruz, işte dizileri biz bu şekilde tanımlarız new olayını ileriki derslerde anlayacağız
            //aslında yukarıdaki yazdığımız array mantığında istediğimiz kadar kursu tek bir değişkende tutabiliriz. Eğer string aa dersek tek bir değişken tutarız ama string[] aa = new string[] dersek birden fazla veri tutabileceğimiz anlamına geliyor  
            //Gerçek hayatta biz bunları bir veri deposundan çağırıyoruz string[] kurslar = kurslarGetir(); gibisinden.
            //Normal şartlarda yukarıdaki gibi hepsini tek tek değişkene atasaydık biz bunları sırayla Console.WriteLine(kurs1), Console.WriteLine(kurs2), Console.WriteLine(kurs3) gibi ekrana bastıracaktık. ama;
            //dizilerde ise işte burada dizi ve döngülerin ilişkisi ortaya çıkıyor dizileri ekrana bastırabilmek için döngüleri kullanırız.(for, foreach, while) hepsine değineceğim. Array içinde 3 tane veri var for döngüsü 3 için teker teker dönecek.
            //hadi yukarıda kurslar arrayimizi for döngüsü ile ekrana bastıralım.

            for (int i = 0; i < 3; i++)//array içinde üçtane verimiz var bundan dolayı i<3 dedik. programlama dilleri saymaya sıfırdan başlar aslında array içinde 0,1,2 tane veri var.
            {
                Console.WriteLine(kurslar[i]); //kurslar[i] yazmamızın sebebi ise biz kursların i'ninci elemanını bastırmak istediğimiz için bu şekilde yazıyoruz.

            }

            Console.WriteLine("Sayfa Sonu");
            Console.WriteLine("***********");

            //eğer biz array içine yeni bir kurs ekleseydik python adında i<4 olacaktı ama bu bizi hala dinamik hala getirmek dinamik hala gelmek için, array içinde kaç kurs olduğunu bizim belirtmememiz gerekiyor otomatik olarak içinde kaç tane veri varsa o kadar döndürmesi gerekiyor bunun içinde biz i<kurslar.Length kodunu yazarsak bu şu anlama gelir array içinde kaç tane veri varsa o kadar for döngüsünü döndür demektir. length = eleman sayısı. Şimdi kurslar arrayimizin içine yeni bir python kursu ekleyelim ve for döngüsünü dinamizleştirelim.

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            //gördüğümüz gibi arttık arrayimizi dinamik şekilde ekrana bastirabiliyoruz. Artık kurs array içine ne eklersek ekleyelim dinamik oluşturduğumuz for döngüsü i<kurslar.Length array içinde kaç veri varsa o kadar dönecektir.
            Console.WriteLine("Sayfa Sonu");
            Console.WriteLine("***********");

            //şimdi diğer bir döngü yöntemi olan foreach döngüsünü göstereceğim.
            //foreach döngüsünü genellikle arraylar için kullandığımız bir yöntemdir. mantığı pythonda olan for döngüsüne benzer.
            //foreach dizi temelli yapıları tek tek dönmeye yarıyor.
            foreach (string kurs in kurslar) //şimdi bu parantez içindekileri aşağıda açıklayacağım.
            {
                Console.WriteLine(kurs);
            }

            //in kurslar --> kursları tek tek dolaş, kurslar dizisini tek tek dolaş
            //kurs --> takma ad diyebiliriz. tek tek dolaşırken her bir elemena takma isim veriyoruz olarak düşünebiliriz.
            //string --> veri tipidir.

            /*
               Not3 = for ile foreach arasındaki temel farklar burada belirteyim ki daha iyi anlama varalım
            1-)foreach ile ekrana bastırma işlemi yaparken Console.WriteLine(kurs) diyoruz yani sadece takma ad kullanmamız yeterli oluyor 
            ancak for ile ekrana bastırma işleminde for döngüsünde bir sayaç sistemi olduğundan dolayı biz kursların i'ninci elemanını basmamız gerekiyor bundan dolayı Console.WriteLine(kurslar[i]) yazıyoruz.

            2-)for each de dizimizin şartını in kurslar dediğimiz de yeterli oluyor yani zaten foreach döngüsünü arraylar için kullanmamız gerektiğinden dolayı in kurslar demek kurslar arrayini tek tek dolaş demek ancak;
            for ile şartımızı belirlerken manuel olarak da i<4 vb. diyebiliriz amacımız dinamikleştirmek olduğundan dolayı array içinde kaç veri varsa o kadar dönmesini sağlamak için i<kurslar.length demeliyiz.

            3-) foreach döngüsünü biz arraylar için kullanırken, for döngüsünü array dışındaki verileri de bastırmak içinde kullanılabilir aslında ikiside array için kullanabiliriz bu her yiğidin bir yoğurt yiyişi mantığı gibidir.


            */

            //bir sonraki konumuz class'lar ile devam edeceğiz...

        }
    }
}
