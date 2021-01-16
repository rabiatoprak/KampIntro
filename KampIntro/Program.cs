
using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //typesafety - tip güvenliği
            //Do not repeat yourself - kendini tekrar etme
            //değer tutucu - allias

            string kategoriEtiketi = "kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirişYapmismi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Buttonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }

            if (sistemeGirişYapmismi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Girşi Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);




        }
    }
}
