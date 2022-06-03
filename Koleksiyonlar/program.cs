using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {//bu dersimizde koleksiyonlar mantığını, işleyişini anlayacağız.
         //koleksiyonlar mantığını anlatırken ilk önce diziler-array mantığına gireceğiz neler yapabiliyorduk ve dizilerde ne yapamıyoruz bundan dolayı neden koleksiyonlar(list) mantığını kullanıyoruz aşağıda açıklayacağım birer birer öncelikle array mantığına deyinelim.

            string[] isimler = new string[] {"Engin", "Murat", "Kerem", "Halil"}; //string array'da string veri tipinde birden fazla veriyi tutuyorduk.
            // string[] isimler --> stack bellek || new string [] {}; --> heap bellekte referans adersini aldı. {} içine de değerleri olacak.
            // yukarıda 4 tane isim yazdık küme içine; bu şu demek. yani ismler string array'i 4 tane elemandan oluşuyor bunları ayrı şekilde tek tek 0.elemanı, 1.elemanı, 2.elemanı diye bastıralım;

            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            //burada isimler array'i içinde olan 4 elemanı bastırmış olduk.
            //şimdi biz bu isimeler dizisine 5.elemanı eklemek istedik aşağıda eklemeye çalışalım;
           
            //isimler[4] = "ilker";
            //Console.WriteLine(isimler[4]);
            
            //çalıştırdığımız anda sınırların dışında (out of range) hatası aldık yani isimler array'inin eleman sayısı 4 ama biz 5.elemanı okumaya çalışıyoruz. 5.elemanı set etmeye çalışıyoruz. isimler array'i içinde böyle bir yer yok bundan dolayı bunu yapamazsın uyarısı aldık.
            //Not = arraylar biz onu oluşturduğumuz zaman o sınırlarda takılır sadece o sınırların dışına çıkaramayız array'i. 4 elemanlı ise 4 elemanlı 5.eleman ekleyemezsin. 
            //aklımıza şu mantık gelebilir 5.elemanı isimler array'i içine eklemek için;
            
            isimler = new string[5]; //bu beş elemanlı bir array demektir. Daha sonra son elemanı ilker yapalım.
            isimler[4] = "ilker";
            Console.WriteLine(isimler[4]);
            //bu kodu çalıştırdığımızda hakikaten uyarı almadan çalıştığını ve ekrada ilker ismini göreceğiz. Ama gel gör ki ilkerden sonra biz 0.eleman olan engini de ekrana tekrardan bastırmak istediğimizde ne olacak. 
            Console.WriteLine(isimler[0]);
            //dikkat ettiğimiz üzere ilkerden sonra boşluk oldu. Aslında ilkerden sonra 0.eleman olan engin geldi ama boş geldi nedeni ise hep aynı şey biz isimler = new string[5] kodunda new dediğimiz anda bellekte yeni bir adres oluşur. aslında 5 elemanlı bomboş bir array oluşturduk boş array içine son eleman olarak ilkeri atadın ve ekrana bastın ancak 0.elemanı, 1.elemanı, 2.elemanı atamadığın için onlar bomboş gelir. dikkat karıştırma new dediğin anda bellekte yeni alan oluştu isimler array'i değil yani isimler array'inin adresi 101 ise new string[5] dediğimiz anda bunun adresi 102 oldu ve boş bir array oluşturdun bunun mantığını aşağıda daha iyi anlayacksın anlatınca. şimdi bunun mantığını anlatalım stack ve heap bellek üzerinden. 
            //Yani kısacası problem dizilerde, oluşturduğumuz diziye yeni elemanlar ekleyip genişletemiyoruz. genişletsek yeni bir array adresi oluşuyor bellekte(boş bir array) bu sefer eski oluşturduğun arrayin değerlerini kaybediyoruz. işte bundan dolayı list yöntemini kullanacağız aşağı tarafta onlardan da bahsedeceğiz.
            //Bu dizilere yeni eleman ekleme ile ilgili aklımıza şu da gelir ya madem ilkeri ekleyeceğiz o zaman direk gidelim string[] isimler = new string[] {"Engin", "Murat", "Kerem", "Halil", "İlker"}; küme içine yazalım neden aşağıda eklemeye çalışıyoruz diyebiliriz ancak biz şu anda eğitim amaçlı array'i manuel yazıyoruz gerçek hayat projelerinde biz bu arrayde olan verileri bir veri kaynağından alacağız yani veri kaynağından gelecek. mesela veri kaynağından veri geldi biz o veri kaynağından gelen diziye yeni bir şey eklediğimizde patlıyoruz bir somut örnek ile açıklayalım. (gerçek hayat projelerinde genellikle array pek fazla kullanılmaz javada da öyle) 
            //şimdi bunun mantığını anlatalım stack ve heap bellek üzerinden. 
            /*
            Not = ***Stack - Heap bellek üzerinden anlatım***
            
            1- Biz ne dedik bellekde Stack ve Heap adında 2 tane alan var dedik.
            2- Referans tipler(array, interface, vb.) ikisini de kullanıyor ancak değer tipler(int, float vb.) sadece stack belleği kullanırlar.
            3- 10.satırımızı aşağıda simüle edelim şimdi string[]isimler --> stack || new string[]{} olan kısmı heap bellekte olacak.
                
                Stack           Heap
            101/isimler      101/[e,m,k,h] --> bunu açıklayalım eşitliğin sol tarafı stack da oluşturuldu biz new dediğimiz anda heapta 4 elemanlı bir yer oluştur demek ve 101 numaralı adresi alsın.
            
            4- ve biz 0.elemanı yazdırmak istedik = Console.WriteLine(isimler[0]); --> bu artık heapde şu şekilde okunacak = 101'in 0.elemanını ekrana bastır- hep referans numarası üzerinden okuma yapacağız.
            5- Daha sonra biz 29.satırımızda isimler = new string[5] yazdık isimler array'i 4 elemanlıyken 5 elemanlı olsun diye ancak new string[5] yazdığımız anda heap bellekte yep yeni bir adres oluşturmuş olduk yani bu kodu şöyle okuyacağız = isimlerin adresi eşittir yeni bir adres şimdi aşağıda simüle edelim.
                
                 Stack           Heap
            101/isimler      101/[e,m,k,h] 
                             102/[ , , , i] --> bunu açıklayalım; bu sefer isimler = new string[5] dediğimizde değerlerini vermemiş çünkü programcı zannediyor ki string[] isimler = new string[] {"Engin", "Murat", "Kerem", "Halil"}; buradaki değerleri kopyalayacak zannediyor aslında öyle değil. yeni bir alan oluştu ve değerleri verilmediği için içi boş bir array oldu daha sonra 30.satırda biz bu boş arrayin 4.elemanına ilker değerini atadık. bunun da referans numarası yeni bir alan olduğu için 102 verdik.

            6- ilkeri yazması normal çünkü biz 31.satırda olan kodda  Console.WriteLine(isimler[4]); --> diyoruz ki yeni referans olduğu için 102 referans numarasını aldı ve 102nin 4.elemanını ekrana bas diyoruz ve geliyor.
            7- ama 33.satırda yazdığımız kodda ise Console.WriteLine(isimler[0]); --> 102'nin 0.elemanını ekrana bas dediğimizde 102 yeni alan olduğu ve içi boş bir array olduğu için 0.eleman boş olduğu için ekrana boş değer basılmış oldu.
             
            özet = ilk olarak string[] isimler = new string[] {"Engin", "Murat", "Kerem", "Halil"}; --> new dediğimiz anda heap bellekte 101 numaralı adres oluştu ve o adres içine isimler arrayin elemanlarını atamış olduk ve artık bu elemanları ekrana bastıracakken 101'in 0.elemanı diyorduk daha sonra;
                   isimler = new string[5] --> dediğimiz anda new takısını kullandığımız için 101 numaralı adresi değiştirdik ve 102 numaralı referans adresine boş array dizisi oluşturmuş olduk neden boş aslında bu şekilde yaparak 101 numarada olan verileri kopyalacak zanneddik ama bu şekilde işleyiş olmuyor. 102 numaralı adrsin 4.elemanına ise ilkeri atadık ve ekrana bastırdığımızda geliyordu ancak ekrana 0.elemanı bastırmak istediğimiz zaman işte 101 numaralı adres değişti artık 101 numaralı adresin yerini 102 numaralı adres almış oldu ve 102 numaralı adres çağırıldığı için 102'nin 0.elemanını ekrana bastırıyor ve bunun sonucunda ekrana boş değer geliyor işte sebebi bu.
            */

            Console.WriteLine("\n");
            Console.WriteLine("List Mantığı Adına..");

            //işte yukarıdaki gibi bir problem olduğu için biz listelerden yararlanıyoruz şimdi listeleri anlatalım aşağıda.
            //şimdi biz yukarıdaki array kodunu list methodu ile nasıl yazabiliriz aşağıda gösterelim
            //List<string> isimler2 = new List<string>();
            //eğer biz bunu yukarıdaki array dizimizdeki eleman kümesi gibi oluşturmak istersek eğer 2 türlü yapabiliriz aşağıda gösterelim.
            
            //isimler2.Add("Engin", "Murat", "...");   //ilk tür yukarıdak listemizi oluşturduk hemen altına bu kod vasıtası ile ekleme yapabilirz. isimler2 ye ekle ne ekliyoruz string veri tipinde veriler. aynı arraydaki gibi düşün. string arrayi gibi değilde string listesi gibi düşünebiliriz. Bir listeye eleman eklemek için kullanıyoruz bu kodu. 

            //ikinci tür ise yukarıdaki kodun aynısını yazarız normal parantez yerine küme kullanırız yani;
            List<string> isimler2 = new List<string> {"Engin", "Murat", "Kerem", "Halil" };

            //şimdi biz bu noktada array daki gibi bu değerleri tek tek okuyabiliriz;
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            //şimdi listemize yeni bir eleman ekleyelim. işte bunu yukarıda da gördüğümüz isimler2.Add kodumuz ile yapacağız.
            isimler2.Add("ilker");
            //daha sonra ekrana bastıralım ve ilkerden sonra da 0.elemanı bastıralım bakalım array de olduğu gibi boş mu gelecek yoksa 0.elemanı bastıracak mı ?
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            //gördüğümüz üzere boş bir değer gelmedi direkt olarak ilkeride ekledik listemize ve listemizin 0. elemanınıda başarılı şekilde ekranımıza bastırmış olduk.
            //Listelerin birden fazla fonksiyonları vardı örnek verecek olursak isimler2. yaptığında bir çok şey önümüze çıkıyor Add vb. gibi bunu ödevler ile takviye edeceğiz burada herşeyi anlatmayı bekleme.
            //bundan sonraki derste -GenericsIntro- da ise eğer c# da list diye bir şey olmasaydı biz bunu nasıl yazardık yani kendi koleksiyonumuzu nasıl yazardık bunun üzerinde konuşacağız.

        }
    }
}
