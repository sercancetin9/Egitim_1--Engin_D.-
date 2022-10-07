using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //METOTLAR TEKRAR TEKRAR KULLANILABİLMEYİ SAĞLAYAN BİR YAPIDIR
            //Dont repeat yourself - DRY - KENDİNİ TEKRAR ETME
            //Clean code - TEMİZ KOD
            //Best practice - DOĞRU UYGULAMA TEKNİKLERİ

            Urun Urun1 = new Urun(); //Clasın örneği denir

            Urun1.Adi = "Elma";
            Urun1.Fiyati = 15;
            Urun1.Acıklama = "Amasya elması";

            Urun Urun2 = new Urun();

            Urun2.Adi = "Karpuz";
            Urun2.Fiyati = 45;
            Urun2.Acıklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {Urun1,Urun2};
            
            //type safe - TİP GÜVENLİ DEMEK. C# VE JAVA TİP GÜVENLİ PROGRAMLAMA DİLLERİDİR

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Id);
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Acıklama);
                Console.WriteLine("---------------");

            }
            Console.WriteLine("");
            Console.WriteLine("***********Metotolar***********");
            Console.WriteLine("");

            //Isntance - CLASS ÖRNREĞİ OLUŞTURMAK
            //encapsulation - ALIŞVERİŞ SİTESİNDEN ÖRENEK VERECEK OLURSAK URUN ADI FİYATI VE AÇIKLAMA
            //SATIRLARI BULUNAN BİR ÜRÜNE CLASS YAPISINDA METOTLARI LULLANARAK ÇOK KOLAY BİR ŞEKİLDE YENİ ÖGE
            //EKLENEBİLİRKEN SADECE METOT YOLUNU KULLANARAK GEREKLERŞTİRİLEN UYGULAMALAR HATA VERECEKTİR.
            //BU DURUMU AÇIKLAMA OLARAK İFADE ETMEK ZOR OLSA DA SEPETMANAGER SINIFINDAKİ EKLE2 PUBLİC İ NE 
            //SONRADAN EKLENEN STOK ADEDİ VERİSİ HATAYA NEDEN OLMUŞ MAİN KLASÖRÜNDEKİ 63. SATIRDA GÖRÜNEN HATA
            //BUNUN BİR ÖRNEİDİR. BU HATALARA MAĞRUZ KALMAMAK İÇİN CLAS YAPISI İLE BİRLİKTE KULLANILAN MATOTLAR
            //ÇOK DAHA DOĞRU BİR KULLANIM YAPISI OLACAKTIR.

            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(Urun1);
            sepetManager.Ekle(Urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 18, 25);
            sepetManager.Ekle2("elma", "Amasya elması", 13, 40);
            sepetManager.Ekle2("Kiraz", "Kastamonu kirazı", 22,);




            Console.ReadLine();

        }
    }
}
