using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılımcı Geliştirici Kursu";
            string kurs2 = "Programlamaya Başlangıç Kursu";
            string kurs3 = "Java";

            // array - dizi

            string[] kurslar = new string[] { "Yazılımcı Geliştirici Kursu",
            "Programlamaya Başlangıç Kursu", "Java", "Python"};


            for (int i = 0; i < kurslar.Length; i++)
            {

                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti");
            
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu");


        }
    }
}
