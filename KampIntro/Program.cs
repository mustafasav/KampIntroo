using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //do not repeat yourself - kendini tekrarlama!!!
            //type safety - tip güvenliği
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.42;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;


            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu Göster");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu Göster");
            }
            else
            {
                Console.WriteLine("Değişim Yok Butonu Göster");
            }


            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
              
                Console.WriteLine("Giriş Yap Butonu");
            }

        }
    }
}
