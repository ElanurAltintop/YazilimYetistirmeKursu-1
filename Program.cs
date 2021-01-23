using System;

namespace YazilimYetistirmeKursu_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //typesafety =tipgücenliği önemli C# ve Java da
            string kategorietiketi = "kategoriler";
            int ogrenciSayisi = 32000;
            double faizorani = 1.45;
            bool sistemeGirisYapmisMi = true; //true
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if(dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }


            if(sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategorietiketi);
        }
    }
}
