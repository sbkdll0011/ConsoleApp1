using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Proglamlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "pyhton";
            string kurs5 = "C#";
            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);
                //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Proglamlamaya başlangıç için temel kurs", "Java", "pyhton" };


            for (int i = 0; i < kurslar.Length; i++) 
            {
                Console.WriteLine(i);

            }
            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)              
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
