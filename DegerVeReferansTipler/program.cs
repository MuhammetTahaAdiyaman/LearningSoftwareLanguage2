using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {//bu bir ara konudur. 

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ? --> 30
            //sayi1 = 10, sayi2 = 30 daha sonra sayi1 i sayi2 ye eşitliyoruz yani sayi1 = 30 sayi2 = 30 oldu daha sonra sayi2 = 65 oldu bize sayi1 i soruyordu cevap = 30 nedenini aşağıda açıklayacağım.

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] {100,200,300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] ? --> 999

            /*
            1-)Yukarıda yazdığımız iki işlemin sonuçlarını aynı mantıkla düşündük ancak sonuçları tahmin ettiğimden farklı çıktı bunun sebebini aşağıda açıklayacağım.
            2-)İlk önce bir kaç notdan bahsedeceğim;
            Not = sayısal veri tiplerine (int, decimal, float, double, bool) değer tip denir. --> değer tip.
            Not2 = array(türü önemli değil int[] sayilar, string[] kelimeler farketmez), class, interface gibi yapılar ise referans tip denir --> referans tip.
            3-)yukarıda yazdığımız iki örneğin sonuçlarının farklı olmasının sebebi değer ve referans tipden kaynaklıdır bunu ayrıntılı olarak açıklayacağım.
            4-) bellekte "stack" ve "heap" denilen 2 alan vardır. biz bir değişken tanımladığımızda int sayi dediğimizde değer tip olanlar sadece "stack" alanında gerçekleşiyor. 
            
            şimdi ilk örneği açıklayalım.

            Stack
            sayi1 = 10 --> değer tipleri biz şu şekilde okuyoruz: sayi1 'in değeri eşittir 10.
            sayi2 = 30 --> sayi2'nin değeri eşittir 30 diye okuruz neden bu şekilde okuyoruz yukarıda da bahsettiğimiz gibi değer tip olduğundan dolayıç
            biz 12.satırda şunu yazıyoruz sayi1 = sayi2 --> sayi1'in değeri eşittir sayi2'nin değeri olarak okuruz. sadece değeri aktarırsın yani burada sayi2 demenin bir anlamı yok değeri eşitler, kopyalar ve sayi1, sayi2 ile irtibatını koparır.
            artık sayi1'in değeri eşittir 30, sayi2'nin değeri eşittir 30 oldu. Daha sonra;
            sayi2'nin değeri eşittir 65 oldu ve bize sayi1 soruldu --> 30 oldu.

            *********************************

            şimdi ikinci örneği açıklayalım
            1-)17.satırda int[]sayilar1 = new int[]{10,20,30}; tanımladık şimdi bellekte stack ve heap diye alan vardı burada int[] sayilar1 dediğimizde stack alanda sayilar1 adında bir değişken tanımlamış olduk. artık new int[]{} dediğimiz anda sayilar1 için heapte yeni bir alan oluştur ve değerleri oraya yaz demek aşağıda göstereceğim  
                  Stack           Heap
                sayilar1        [10,20,30]
            
            2-)bu şekilde oldu. Peki stack ile heap arasında bağlatıyı nasıl kuracağız ? şu şekilde bu heap ve bunun bir adresi var bir adres değeri tutuyor ve bu adres değerine 101 diyelim aşağıda göstereceğim sıra sıra.  
                    Stack             Heap
               101/sayilar1 -->   101/[10,20,30] //yani sayilar1 heap kısmında 101 adresli alana işaret ediyor. yani sayilar1 in karşılığı bellekte 101 numaralı adreste 

            3-)daha sonra 18.satırda int[] sayilar2 = new int[]{100,200,300} adında bir şey tanımladık. int[] sayilar2 dediğimizde stack alanda sayilar2 adında bir değişken tanımlamış olduk. artık new int[]{} dediğimiz anda heap sayilar2 için heapte yeni bir alan oluştur ve değerleri oraya yaz demek anlamında oldu aşağıda göstereceğim.
                    Stack              Heap
                101/sayilar1 --->  101/[10,20,30]
                102/sayilar2 --->  102/[100,200,300] //yani sayilar2 heap kısmında 101 adresli alana işaret ediyor. yani sayilar2 nin karşılığı bellekte 102 numaralı adreste 

           **** Not3 = demekki biz class, method, array kullanımlarında kullandığımız new ifadesi bellekten bir adres oluştur anlmaına gelmektedir.

            4-) arraylar referan tiptir. 19.satırda sayilar1 = sayilar2 aslında şu şekilde okumalıyız; sayilar1'in referans numarası(101), sayilar2'nin referans numarasına(102) eşittir diye okumalıyız. hem sayilar1 hem de sayilar2 nin bellekte karşılığı 102 referans numaralı adres oldu. Aşağıda gösterelim;
                    Stack             Heap
               102/sayilar1 --->   102/[100,200,300] oldu artık 101/[10,20,30] değil 
               102/sayilar2 --->   102/[100,200,300]
               //yani 102 yi 101e atamış olduk. Değer tiplerde değeri atıyoruz, referans tiplerde adresi atıyoruz.
            
            5-) 20.satırda sayilar2[0] = 999; sayilar 2 nin yani 102nin referans numarasının 0.elemanı yani 100 artık 999 oldu. yani burada sayilar1, sayilar 2 ye göre değil 102 numaralı referans adresine göre 999 yazdık ve 102 numaralı referans adresi hem sayilar1 hem de sayilar2 ye ait olduğundan dolayı ikisininde 0.elemanı 999 oldu.
                    Stack             Heap
               102/sayilar1 --->   102/[999,200,300] 
               102/sayilar2 --->   102/[999,200,300]

            6-) 21.satırda ise soru olarak sayilar1[0] ? --> sayilar1'in referans numarasının yani 102'nin 0. elemanı kaçtır diye sorduk. bunun cevabı da 999 oldu. Bunun sebebi ise yani burada sayilar1, sayilar 2 ye göre değil 102 numaralı referans adresine göre 999 yazdık ve 102 numaralı referans adresi hem sayilar1 hem de sayilar2 ye ait olduğundan dolayı ikisininde 0.elemanı 999 oldu.

            //bu c gibi dillerde karşımıza pointer ismi ile çıkar.
            // 101 numaralı adresi stack de kimse tutmuyor bu adrese ne olacak derseniz ? birazdan .net'in garbage collector isimli çöp toplayıcısı gelecek diyecek ki arkadaşım seni tutan kimse yok bu saatten sonra senin bir anlamında yok o yüzden ben seni bellekten atıyorum diyor. 
            
            Not3 = değer tiplerde (int float...) sayi1 = sayi2 dediğimizde sayi1'in değeri eşitti sayi2'nin değeri olarak algılarız ve burada değer ataması şeklinde yaparız (eşitlenen şey değer) ancak;
            referans tiplerde(class, array..) sayilar1 = sayilar2 dediğimizde ise sayilar1'in referans numarası adresi eşittir sayilar2'nin referans numarası adresine eşittir olarak algılamayız ve burada referans adresine yönelik atama yapılmaktadır. (eşitlenen şey referans adresi)
             */



        }
    }
}






/*
    Odevler - 3.gün

1-)ref ve out anahtar kelimelerini bilmeyen birine nasıl anlatırdınız?
Cevap: 
ref değer tipi değişkeni referans  tipli  gibi kullanmak için yapılan işlemdir.  Yani aslında değişkenin değerini değil adresini tutar ve adres üzerinden işlem yapılmış olur. Hem metot içerisinden değişken den önce tanımlama yapılırken yazılmalı hemde metodu çağırırken yazılmalıdır.  Ref tipli değişken başlagıç değişkeni set etmeliyiz yani değer atama işlemi yapılmalıdır. 

Out ref tipi ile aynı işlemi yapmaktadır. Ref  tipinden farklı başlangıçta  değişkeni set etme işlemi yapmanıza gerek  bulunmamaktadır. Out tipi değişken de metot içerisinde 1 defa set edilme yani değer atama işlemi yapılmalıdır
 
 Örnek olarak bir bankada yazılım yazıyorsunuz ve faiz oranı bellidir. 0.52. eğer biz bunu müşteriye özel kılmak istiyorsak burada değişebilirlik söz konusu ise bu referans tiplerini kullanabiliriz.

int sayi1 = 35;
int sayi2 = 45;
console.writeLine(toplam(ref sayi1, sayi2)); --> bunun sonucu 45+45 = 90 olacak çünkü biz sayi1 = 35 dedik ancak referans olarak aldık yani method içinde sayi1 tekrardan güncellendi ve 45 oldu. ama biz direk sayi1 i bastırırsak 35 olarak gözükecektir aşağıda örnek olarak göstrerelim
console.writeLine(sayi1); --> bunun sonucu 35 olacaktır.


static int toplam(ref int sayi1, int sayi2)
{
    sayi1 = 45;
    return sayi1 + sayi2;
}
 
 
***********************************************************
 
2-) Bir bankada müşteri takibi yapmak istiyorsunuz.
Musteri isimli bir Class oluşturunuz. Müşteriye istediğiniz özellikleri ekleyiniz. (Id,Ad,Soyad....)
MusteriManager sınıfı oluşturunuz. Musteri parametresi alarak Musteri ekleme, listeleme,silme gibi metotları simule ediniz.
 
bunu yan pencerede yeni bir ödev 2 sekmesinde oluşturmuş olacağım adı ödev2müşteritakibi
 
 
 
 
 
 
 
 
 
 
 
 
 */
