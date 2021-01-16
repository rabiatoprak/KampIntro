using System;

namespace ForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunKategori = "Telefonlar ve Aksesuarlar";
            urun1.UrunAdi = "Cep Telefonları";
            urun1.UrunModel = "General Mobile GM 20";
            urun1.UrunFiyat = 1612.80;

            Urun urun2 = new Urun();
            urun2.UrunKategori = "Telefonlar ve Aksesuarlar";
            urun2.UrunAdi = "Akllı Saatler";
            urun2.UrunModel = "Honor Lava Akıllı Saat";
            urun2.UrunFiyat = 712.46;

            Urun urun3 = new Urun();
            urun3.UrunKategori = "Veri Depolama";
            urun3.UrunAdi = "USB Bellekler";
            urun3.UrunModel = "Sandisk 128 Gb iXpand Mini USB";
            urun3.UrunFiyat = 261.40;

            Urun urun4 = new Urun();
            urun4.UrunKategori = "Bilgisayarlar";
            urun4.UrunAdi = "Dizüstü Bilgisayarlar";
            urun4.UrunModel = "HP 255 G7 Dizüstü Bilgisayar";
            urun4.UrunFiyat = 6093.90;

            Urun urun5 = new Urun();
            urun5.UrunKategori = "Televizyonlar ve Ev Sistemleri";
            urun5.UrunAdi = "Projektörler";
            urun5.UrunModel = "Xiaomi M055MGN Mijia Projeksiyon Cihazı";
            urun5.UrunFiyat = 3494.50;

            Urun[] urunler = new Urun[] { urun1, urun2, urun3, urun4, urun5 };

            int i = 0;
            while (i < urunler.Length)
            {
                Urun urun = urunler[i];
                Console.WriteLine("\n" + urun.UrunKategori + " => " + urun.UrunAdi + " => " + urun.UrunModel + " => Fiyatı: " + urun.UrunFiyat);
                i++;
            }
            /*for (int i = 0; i < urunler.Length; i++)
            {
                Urun urun = urunler[i];
                Console.WriteLine("\n" + urun.UrunKategori + " => " + urun.UrunAdi + " => " + urun.UrunModel + " => Fiyatı: " + urun.UrunFiyat);
            }


            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.UrunKategori + " " + urun.UrunAdi + " " + urun.UrunModel + " " + urun.UrunFiyat);
            }*/
        }
    }
    class Urun
    {
        public string UrunKategori { get; set; }
        public string UrunAdi { get; set; }
        public string UrunModel { get; set; }
        public double UrunFiyat { get; set; }
    }
}
