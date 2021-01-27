using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //type-safe --->>> tip güvenliği
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------");
            }

            Console.WriteLine("------Metotlar--------");

            //encapsulation 

            SepetManager sepetManager = new SepetManager(); //class tan instance - örnek oluşturma
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
           
            sepetManager.Ekle2("Armut","Yeşil Armut",12,10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12,8);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu",10, 12);
            sepetManager.Ekle2(urun1.Adi, urun1.Aciklama, urun1.Fiyati,10);
        }
    }
}


//Do not repeat yourself!!!! Kendini tekrar etme - (DRY)
//Clean Code - Temiz Kod
//Best Practice - Doğru Uygulama Teknikleri