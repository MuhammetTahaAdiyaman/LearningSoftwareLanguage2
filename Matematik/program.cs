using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {//bunu oluşturmamızın sebebi metotlar mantığını daha iyi özümseyebilmeyi sağlayabilmek için.
         //burada hesap makinesinin dort islemini oluşturmak.
         //metodumuzu çağırabilmek için öncelikle classımızın bir örneğini oluşturmalıyız. daha sonra metodumuzu çağırmalıyız çünkü metodumuz class içinde oluşturduk.
            DortIslem dortislem = new DortIslem();

            dortislem.Topla(5, 8);
            //şimdi bu fonksiyonu biz başka sayfada tekrardan farklı sayılar ile yazabiliriz.İşte parametre olmasının sebebi hep aynı olmaması için değişkenlik gösterebilir aynı sepete ürün eklemek gibi. Sepete ürün eklerken her seferinde aynı ürünü eklemediğimiz için, değişken olduğu için parametremiz urun olmuştu. Yani parametreler değişken olanlardır.
            dortislem.Topla(10,12);

            //burada metod içinde kullandığımız parametrenin ne anlamda kullandığımızı anlamış bunuluyoruz. 
        }
    }
}
