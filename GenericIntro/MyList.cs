using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{//List yapısında olduğu gibi <> bu generic yapıyı class yapısında kullanmak istiyorsak eğer class MyList <T> şeklinde birşey yapmamız gerekiyor bunu yan tarafında açıklamasını yapacağım.

    class MyList<T> //şimdi <> bunun içine illa string gelecek diye bir kaide yok int, float, product class, productManager class yapılarıda gelebilir ancak burada olduğu gibi generic yapıyı oluşturmak istiyorsak ve bu generic bir tane değer alıyorusa <T> şeklinde yazarız T = type, tip den gelir veri tipinden.
    {//<T> --> bana bir tip ver ben aşağıyı ona göre yapılandıracağım demek. Aslında bir önceki derste Koleksiyonlar yapısında list yapısını gördük şimdi List<string> yazdığımızda bu listeye eklenecek veriler string veri tipinde olması gerekmektedir yoksa kabul etmiyordu yani <> bunun içine ne yazarsak söz vermiş oluyoruz ve yapıyı bu veri tipi üzerinde kurduğumuzdan işte buradaki anlam buna çıkıyor.
     //Koleksiyonlar projemis List mantığında listeye elemanı nasıl ekliyorduk isimler2.Add(); şeklinde ekliyorduk. işte bu class yapısı içinde de Add fonksiyonunu oluşturalım ve bu fonksiyon sayesinde koleksiyonumuza veri ekleme yapalım.    

        T[] items;//18.satırın devamı niteliğindedir. Şimdi biz bu T[] items; array'ini newlememiz gerekiyor yani bellekte referans numarası oluşturmamız gerekiyor yani adreste olsun istedik ve bunu class'ı newlediğim zaman oluşturmam gerekiyor. 0 elemanlı dahi olsa ben bu diziyi newlemem gerekiyor. Bunun için aşağıda ctor kısayolunu kullanmamız gerekiyor.
        public MyList()//ctor kısayolu--> constructor methodu da diyebiliriz. MyList class'ını bir yerde newlediğimiz zaman bu otomatik çalışıyor yani başlangıçta çalışıyor class ismi ile aynı olur. İşte biz items arrayini bunun içinde newlememiz gerekiyor nedenini aşağıda açıklayacağım.
        {//newlediğimiz anda çalışan bloğa constructor deniliyor. Newlediğimiz anda array'ı oluşturduk ve 0 elemanlı oldu.  
         //biz bu bloğu neden oluşturduk şimdi biz yukarıda bir items array'ı oluşturduk ya biz bunu Add metodu içine ekleyebilmemiz için newlememiz gerekiyor ve başladığında ben onu newlemek ve 0 elemanlı olarak newlemek istiyorum bir class newlendiğinde çalışan bloğa constructor bloğu denir.    
            items = new T[0]; //şimdi bu 0 elemanlı arrayimize elemanı Add metodunda ekleyeceğiz ancak 0 elemanlı bunu nasıl yapacağız eleman sayısını items = new T[1] yazarsak hepsi 1 elemanlı olacak bunu nasıl yapacağız şimdi Add metodu içinde gösterelim
        }
        public void Add(T item) //gelip buraya parametre olarak string yazarsak - "string Item" --> bizim Add metodumuz string ile çalışmak zorunda. Onun yerine ben diyorum ki benim çalışacağım veri tipi o an programcı newlerken ne derse hangi veri tipini söylerse o olsun dersek "T Item" yazarız. T = Verdiğimiz tipe karşılık gelir. Şimdi program.cs ye geçelim bu oluşturduğumuz MyList'i bir kullanalım. 
        {
            T[] tempArray = items; //geçiçi dizinin referansı eşittir items referansına. artık bu şekilde elemanlarım kaybolacak diye korkmuyorum çünkü onu başka bir arkadaşa emanet ettim gibi düşünebiliriz. 22.satırda anlatmak istediğimiz nokta burası. 
            items = new T[items.Length+1]; //işte 16.satırda eğer T[1] yazarsak 0 elemanlı dizi 1 elemanlı olacak ve hepsi 1 elemanlı olacak şekilde çevrilecekti biz items.Length dizinin eleman sayısını gösteriyordu işte biz bunu newlediğimizde ve items.Length+1 dediğimiz taktirde dizimin eleman sayısını 1 arttırmak istiyorum dedik. bu şekilde yazmamızın sebebi ise dinamikleştirdik yani 3.4.elemanı eklediğimiz zaman eleman sayısı artacak bu şekilde yaparak hep bir arttırımını sağlayacağız eleman sayısının
            //işte burada da bir sorun çıkıyor newlediğimiz anda ne oluyordu yeni referans numarası ortaya çıkıyordu ve orada ki atanmış değerler uçuyordu işte bunu çözebilmek için o referans noyu birine tutturmamız gerek bunu da hemen metod içinde yukarıda göstereceğim.

            for (int i = 0; i < tempArray.Length; i++)//emanet olarak verdiğimiz verileri tempArray den geri alacağız onları
            {
                items[i] = tempArray[i] //burada diyoryz ki --> benim items'ımın i.elemanı eşittir tempArrayden gelen geçiçi olarak verdiğim i.elemandır. yani emaneten verdiğim değeri sırasıyla kendi üzerimize itemsa yeniden alıyoruz 
                //artık burada items kendi değerlerine kavuşmuş oldu.
             }
            items[items.Length - 1] = item; //burada şu şekilde anlatalım. şimdi bizim items arrayi 4 elemanlı olsun içinde t,e,h,f olsun biz bu array'a yeni bir eleman eklemek için bu arrayin uzunluğunu Length+1 1 arttırdık daha bundan önce biz bu elemanları geçiçi olarak bir yere atadık çünkü newlediğimizde elemanlarımız kaybolmasın diye. daha sonra bu geçiçi olarak emanet ettiğimiz elemanları for döngüsü içinde sırayla gezdirdik emanet olan yerde ve gezdirdiğimiz elemanları geriye aldık i.eleman olarak. en sonunda şöyle oldu bu 4 elemanlı 5 elemanlı array oldu ve 5 elemanlı arrayn 4 ü doldu(eski değerlerine kavuştu) sonuncu olan 5.değeri ise for döngüsünden sonra burada yazdığımız kod ile yukarıda Add metodu ile atayacağımız değeri getirmiş olduk. neden Length-1 yazdık bu sonuncu eleman demek.
        }
    //şimdi buraya geldik. Program.cs de yazdığımız List aslında arka planda bir array'i yönetiyor. Bir array kullanıyor. Şimdi biz de burada bir array tanımlayalım ve onu yönetelim yukarıda tanımlayalım arrayimizi items adında. 
    //11.satırda yazdığımız items array'ini Add methodunun dışına yazdık neden, çünkü Add metodunun dışında yazdığımız değişken MyList class'ının içinde ve biz bu sayede ister Add metodu içinde(14.satır) istersek aşağıda farklı bir method yazsak oradan da  biz bu arraya'e erişim sağlayabiliriz. Yani kısacası MyList class'ının bütün metod(operasyonlarının) erişim sağlaması için bu items array'ini metod dışına yazdık.
    }
}
