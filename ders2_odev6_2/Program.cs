using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders2_odev6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Urun Urun1 = new Urun();

            Urun1.UrunAdi = "Ayakkaı";
            Urun1.UrunFiyati = 350;
            Urun1.İndirimMiktari = 10;
            Urun1.UrunKategorisi = "Giyim";
            Urun1.Urunmarkasi = "Nike";

            Urun Urun2 = new Urun();

            Urun2.UrunAdi = "Tişört";
            Urun2.UrunFiyati = 150;
            Urun2.İndirimMiktari = 20;
            Urun2.UrunKategorisi = "Giyim";
            Urun2.Urunmarkasi = "Adidas";

            Urun Urun3 = new Urun();

            Urun3.UrunAdi = "Traz Makinesi";
            Urun3.UrunFiyati = 500;
            Urun3.İndirimMiktari = 15;
            Urun3.UrunKategorisi = "Temizlik";
            Urun3.Urunmarkasi = "Braum";

            Urun Urun4 = new Urun();

            Urun4.UrunAdi = "Saat";
            Urun4.UrunFiyati = 850;
            Urun4.İndirimMiktari = 5;
            Urun4.UrunKategorisi = "Aksesuar";
            Urun4.Urunmarkasi = "Seiko";

            Urun Urun5 = new Urun();

            Urun5.UrunAdi = "Araba";
            Urun5.UrunFiyati = 350000;
            Urun5.İndirimMiktari = 2;
            Urun5.UrunKategorisi = "Araç";
            Urun5.Urunmarkasi = "BMW";

            Urun Urun6 = new Urun();

            Urun6.UrunAdi = "Ev";
            Urun6.UrunFiyati = 3500000;
            Urun6.İndirimMiktari = 4;
            Urun6.UrunKategorisi = "Mülk";
            Urun6.Urunmarkasi = "Yokk";

            Urun Urun7 = new Urun();

            Urun7.UrunAdi = "Televizyon";
            Urun7.UrunFiyati = 12000;
            Urun7.İndirimMiktari = 12;
            Urun7.UrunKategorisi = "Elektronik";
            Urun7.Urunmarkasi = "Samsung";

            Urun[] Urunler = new Urun[] { Urun1, Urun2, Urun3, Urun4, Urun5, Urun6, Urun7 };

             for(int i = 0; i < Urunler.Length; i++)
            {
                Console.WriteLine((i+1)+". Ürünün adı: "+ Urunler[i].UrunAdi+"\n"+
                    (i + 1) + ". Ürünün fiyatı: " + Urunler[i].UrunFiyati + "\n" +
                    (i + 1) + ". Ürünün indirim miktarı: " + Urunler[i].İndirimMiktari+ "\n" +
                     (i + 1) + ". Ürünün kategorisi: " + Urunler[i].UrunKategorisi + "\n" +
                     (i + 1) + ". Ürünün markası: " + Urunler[i].Urunmarkasi);
            }


            Console.ReadLine();
        }
    }
    class Urun
    {
        public string UrunAdi { get; set; }

        public int UrunFiyati { get; set; }

        public int İndirimMiktari { get; set; }

        public string UrunKategorisi { get; set; }

        public string Urunmarkasi { get; set; }



    }
}
