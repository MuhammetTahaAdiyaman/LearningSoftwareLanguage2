using System;
using System.Collections.Generic;
using System.Linq;
//ödev 3 ve 4 --> Aynen derste yaptığımız MyList gibi siz de kendi Dictonary sınıfınızı yazınız. Sadece ekleme(Add) metodunu yazınız. (MyDictionary) ve Dictionary mantığını araştırınız.
//anlamazsanhttps://www.youtube.com/watch?v=I9RZPY4lD2k burada var.

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///*1-)dictionary sınıfı içinde sizin belirleyeceğiniz bir key'e uygun olarak değer saklar.
            //zorunluluğu vardır.

            // 2-)key türünü belirtmemiz şart (string, int vb...)
            // */
            //Dictionary<string, int> AdYas = new Dictionary<string, int>(); //dictionary yapısı aynı list yapısı benzerliği taşıyor
            ////bu yapıya verilerimizi ekleyelim
            //AdYas.Add("Ecem", 21);
            //AdYas.Add("Taha", 22);
            //AdYas.Add("Beyza", 19);
            ////bu yapıdaki verileri ekrana bastıralım
            //foreach (var degeroku in AdYas)
            //{
            //    Console.WriteLine(degeroku);
            //}
            ////bu yapının bir diğer özelliği olan bu değerleri sayabilme özelliği vardır onu da gösterelim.
            //var eleman = AdYas.Count();
            //Console.WriteLine(" ");
            //Console.WriteLine("eleman sayisi:  "+eleman);
            ////bu yapının bir diğer özelliği verileri silme özelliği de vardır onu da gösterelim
            //AdYas.Remove("Beyza");
            //Console.WriteLine();

            //foreach (var degeroku in AdYas)//veriyi sildikten sonra tekrar bastıralım emin olmak için ve görebilmek için
            //{
            //    Console.WriteLine(degeroku);
            //}
            //var eleman2 = AdYas.Count();
            //Console.WriteLine();
            //Console.WriteLine("Eleman sayisi: " + eleman2);
            //Console.ReadLine();

            //şimdi ödevimize gelelim aynı Listelerde yaptığımız gibi bunun mantığını kavramamız için dictionary olmadığında kendimiz bu yapıyı nasıl kullanırız yani kendi MyDictionary yapısını oluşturalım sadece Add metodunu anlatalım. yukarıyı yorum satırına alıyorum.

            /*
            -Yapılacaklar Sırası-
            1-) İlk önce MyDictionary yapısını kuracağız nedeni List gibi Dictionary'de yeşil renkli olanlardan yani class yapısına sahipti.
            
            2-)Daha sonra Dictionary ve List yapısında Add metodu vardır. Bizim oluşturduğumuz MyDictionary Class içine Add metodu oluştur.
            
            3-) MyDictionary oluşturduk ama bu yapıda şöyle bir generic özellik var "<>". bu yapı içine verinin türünü belirliyoruz ve ne belirlersek onun türünde işlem yapılabiliyor
            yani verinin türünü programcı ne girerse o şekilde bir işlem sağlayabilmemiz için MyDictionary<T> yapmmalıyız class adını bu T = type demektir. bunu çoğaltadabilirz MyDictionary<T,K>
            
            4-) Bu Dictionary ve List de olan Add metoduna bakalım biz Dictionary sınıfında veri türü olarak ne girersek Add metodu da aynı girdiğimiz veri türünde değer istiyor.
            Şimdi bizim MyDictionary class'ı içinde olan Add metoduna string girersek parametre olarak, bu metod string ile çalışmak zorunda olacak. Dictionary yapısı gibi kullanıcı veri türü olarak ne belirlerse o şelilde çalışması için "public void Add(T item, K keys) şeklinde düzenlememiz gerekiyor--> parametreler küçük yazılır camel types.
            T,K olarak belirlersek veri türümüzü programcı hangi veri tipini belirlerse o veri tipi ile bu fonksiyon çalışması sağlanacaktır.

            5-) Daha sonra Dictionary veya List'te özellik olan Add metodu gerçekten veriyi eklerken bizim Add metodumuz boş yapıya sahio. Add metodunu diğer add metodu gibi yapacağız ama bilmemiz gereken bir kaç şey var;
            --> Dictionary veya List gibi yapıların arka planlarında array bazlıdır. bunu nasıl anlıyoruz biz bir List veya Dictionary yapısı oluşturduğumuzda şu kodu yazdığımızda;
            ilk önce oluştur --> Dictionary<string, int> AdYas = new Dictionary<string, int> ();
            daha sonra --------> var eleman = AdYas.Count();
                                 Console.WriteLine("eleman sayisi: " + eleman);
            yaptığımızda ekrana 0 değeri gelecektir. Bu 0 değerinin anlamı bu liste eleman sayısının 0 olduğunu gösterir yani buraya hiç veri eklenmemiştir.

            6-) bundan dolayı arka planda array çalıştığı için bizde MyDictionary classımıza 2 tane array oluşturuyoruz;
            T[] Item;
            K[] Keys;

            7-) bir tane constructor yapmamız gerekiyor bunun sebebi sie Dictionary yapısını ilk oluşturduğumuz yani newlediğimiz anda count = 0 işte bizim MyDictionary classımızda da eleman sayısını ilk olarak 0 olması gereklidir.
            Bunu constructor yapısı içinde kullanıyoruz çünkü bir class'ı newlediğimiz zaman ortaya çıkan bloğa constructor diyoruz. işte burada da biz array'i newledik ve ilk ooluşumunu sağladık. bundan dolayı constructor yaousu içinde kullanacağız;
            Item = new T[0];
            Keys = new K[0];

            8-) Son olarak da bu oluşturduğumuz 0 elemanlı arraylarimize eleman ekleyeceğiz Kural = bu arraylarimize veri ekledikçe arraylarimizin eleman sayısının 1 artması gerekmektedir.
            Array mantığınıda hatırlayalım. arraylerde eleman sayısını bir arrtırdıkça newlememiz gerekiyordu. bu işlemleri de metodumuz olan Add metodu içinde yapacağız.
            Item = new Item[Item.Length+1];
            Keys = new Keys[Keys.Length+1];

            9-) Ancak bşz arraylari newlediğimiz için referans adresini değiştirdik ve arraylarde bulunan verileri kaybettik. Bunu önlemek için newlemeden yani eleman sayısını arttırmadan yani yukarıdaki işlemi yapmadan önce geçiçi array ile referans adreslerini tutalım daha sonra newleyelim.
            T[] tempArrayT = Item;
            K[] tempArrayK = Keys;

            Item = new Item[Item.Length+1];
            Keys = new Keys[Keys.Length+1];

            10-) Daha sonra biz bu ödünç verdiğimiz verilerii geri alalım yani geçiçi arraylarin tuttuğu adreste olan verileri yeni adresimize çekelim.
            for(int i = 0; i<tempArrayK.Length; i++)
            {
                Keys[i] = tempArrayK[i];
                Item[i] = tempArrayT[i];
            }

            11-) Artık arrayimizin eleman sayısı arttı ve 4 ise 5 elemanlı bir array oldu. 4 elemanımızı ödünç verdik onları geri aldık son olarak son elemanımızı eklemek kaldı;
            Item[Item.Length-1] = item;
            Keys[Keys.Length-1] = keys;

            */

            Dictionary<string, int> AdYas = new Dictionary<string, int>(); //Dictionary yapısı
            AdYas.Add("Taha", 22);//bu şekilde dictionary yapısına verimizi ekledik

            //şimdi bizim yapımızı çağıralım.
            //MyDictionary AdYas2 = new MyDictionary(); normalde bir class yapısını bu şekilde çağırıyorduk ancak bizim oluşturduğumuz class yapısı generic yapıya uygun olduğu için şu şekilde çağıracağız.
            MyDictionary<string, int> AdYas2 = new MyDictionary<string, int>(); //bizim olyşturduğumuz MyDictionary classımzı çağırdık. Şimdi bu yapıya veri eklemek için metodumuzu çağıralım.
            AdYas2.Add("Ecem", 21);

            //Şimdi yukarıdaki Dictionary yapısı ile bizim oluşturduğumuz arasında bir problem var yuakrıdaki dictionary yapısı veriye eklendi ancak bizim bu add metodu bir yere eklemedi çünkü içi boş. Peki biz de yukarıdaki dictionary yapısı gibi veriyi nasıl ekleriz MyDictionary classımızda.
            //Bu dictionary veya List gibi yapılar arka planda array bazlı yapılar olduğunu biliyorduk o zaman bizim burada yapmamız gereken işlem ilk önce MyDictionary class'ı içinde array oluşturmak ve ilk değeri ise 0 a atamak olmalı bunun nedeni şu List veya Dictionary yapıları newlediğimiz zaman eleman sayısı 0 olarak ekrana gelmekedi var eleman = AdYas.Count(); yaptığımızda veri eklemeden yaptığımızda ekranda 0 değerini göreceğiz işte ilk önce bizim de MyDictionary class'ımızın eleman sayısı 0 olsun aynı mantık çerçevesinde ilerleyelim. ilk oluşturduğumuz anda newlediğimiz için eleman sayısı 0 demiştik ya işte burada daha önceki dersler de öğrendiğimiz Constructor metodunu da kullanacağız.(ilk oluşturma için)

        }
    }

    class MyDictionary<T, K>
    {
        //şimdi 58.satırda yazdığımız gibi Dictionary ve List arka planda array bazlı olduğu için bizde class yapımıza array oluşturacağız.
        T[] Item;
        K[] Keys;

        T[] tempArrayT;
        K[] tempArrayK;
        //şimdi yine 58.satırda bahsettiğimiz gibi Dictionary ve List gibi yapıları ilk oluşturduğumuzda eleman sayıları 0 olarak gözükmektedir bu da array bazlı olduğunu anlıyorduk bizim de classımızın ilk oluşumunda ya newlediğimiz anda array oluşturduğumuz için bu arrayların eleman sayıları 0 a eşitlemeliyiz işte bunu Constructor yapısı içinde yapmalıyız çünkü constructor = bir class'ı newlediğimiz zaman çalışan blokdu. yani newlemek ilk oluşum süreciydi.
        public MyDictionary()
        {
            Item = new T[0];
            Keys = new K[0];
        }
        //şimdi 0 elemanlı arraylarımız olduğuna göre her veri eklediğimizde eleman sayısını bir arttırmamız gerekmez mi arrayları hatırlayalım eleman sayısını bir arttırdığımızda newlememiz gerekiyordu ve newlediğimiz anda değerleri kaybediyorduk çünkü yeni referans adresi oluşuyordu işte bundan dolayı biz yeni bir geçiçici array oluşturup bu arraylarimizin adreslerini onlara vereceğiz. daha sonra ödünç verdiğimiz elemanları geri alacağız.
        public void Add(T item, K keys)
        {
            T[] tempArrayT = Item; //bu ikiside geçiçi arraydir sebebi sie biz Item ve Keys arraylarında eleman sayısını bir arttırmamız için newlememiz gerekiyor newlediğimiz anda yeni bir referans adresi açılıyor ve değerleri kaybediyoruz işte bu geçiçi değerler bizim eski adreslerimizi tutuyor daha sonra aşağıda o geçiçi değerlerin tuttuğu adreslerden for döngüsü ile ile Keys ve Item değerlerine ödünç verdiğimiz verileri geri alacağız.
            K[] tempArrayK = Keys;

            Item = new T[Item.Length + 1]; //her veri eklendiğinde array'in eleman sayısını bir arttır.
            Keys = new K[Keys.Length + 1]; //her veri eklendiğinde array'in eleman sayısını bir arttır.

            for (int i = 0; i < tempArrayK.Length; i++)
            {
                Item[i] = tempArrayT[i]; //biz bu döngü ile yukarıda geçiçi olarak veridğimiz elemanları geri aldık.
                Keys[i] = tempArrayK[i];
            }
            //ardık sırada bu array dizimizin eleman sayısını arttırdığımız için son elemanlarını eklemeye bunu da şu şekilde yapacağız.
            Item[Item.Length - 1] = item;
            Keys[Keys.Length - 1] = keys;


        }






    }





}
