﻿using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

    
            string adi = "Engin";
            int yas = 36;
            
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem";
            kurs2.IzlenmeOrani = 45;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "pyhton";
            kurs3.Egitmen = "ahmet";
            kurs3.IzlenmeOrani = 98;





            //Console.WriteLine(kurs1.KursAdi + " : " +kurs1.Egitmen);
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs1.KursAdi + " : " + kurs.Egitmen);
            }
            
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}