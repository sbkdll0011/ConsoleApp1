using System;

class MainClass
{
    public static void Main(string[] args)
    {
        //urun1
        Urun urun1 = new Urun();
        urun1.UrunAdi = "Saat";
        urun1.UrunSirasi = "01";
        urun1.UrunFiyati = 12.99;
        urun1.UrunFiyatii = " TL";
        //urun2
        Urun urun2 = new Urun();
        urun2.UrunAdi = "Kulaklık";
        urun2.UrunSirasi = "02";
        urun2.UrunFiyati = 152;
        urun2.UrunFiyatii = " TL";
        //urun3
        Urun urun3 = new Urun();
        urun3.UrunAdi = "Bilgisayar";
        urun3.UrunSirasi = "03";
        urun3.UrunFiyati = 651541;
        urun3.UrunFiyatii = " TL";
        // diziler
        Urun[] urunler = new Urun[] { urun1, urun2, urun3 };


        Console.WriteLine(" -FOREACH İÇİN- ");
        foreach (var urun in urunler)
        {
            Console.WriteLine(urun.UrunSirasi + " - " + urun.UrunAdi + " : "
            + urun.UrunFiyati + urun.UrunFiyatii);
        }


        Console.WriteLine(" -FOR İÇİN- ");
        for (int i = 0; i < urunler.Length; i++)
        {
            Console.WriteLine(urunler[i].UrunSirasi + " - " + urunler[i].UrunAdi + " : "
          + urunler[i].UrunFiyati + urunler[i].UrunFiyatii);
        }

        Console.WriteLine(" -WHILE İÇİN- ");
        int d = 0;
        while (d < urunler.Length)
        {
            Console.WriteLine(urunler[d].UrunSirasi + " - " + urunler[d].UrunAdi + " : "
            + urunler[d].UrunFiyati + urunler[d].UrunFiyatii);
            d++;
        }

    }
}

class Urun
{
    public string UrunAdi { get; set; }
    public string UrunSirasi { get; set; }
    public double UrunFiyati { get; set; }
    public string UrunFiyatii { get; set; }
}
