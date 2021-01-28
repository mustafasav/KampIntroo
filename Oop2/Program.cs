using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gerçek Müşteri İçin
            //mustafa sav için
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "123456";
            musteri1.Adi = "Mustafa";
            musteri1.Soyadi = "Sav";
            musteri1.TcNo = "1234567890";

            //Tüzel Müşteri İçin
            //Kodlama.IO müşteri
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.IO";
            musteri2.VergiNo = "1234567890";

            // Gerçek Müşteri - Tüzel Müşteri
            //SOLID 



            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager musteriManager = new CustomerManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            

        }
    }
}
