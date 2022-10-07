using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders3_1
{
    internal class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi: " + urun.Adi);
            Console.WriteLine("Sepete eklendi: " + urun.Id);
            Console.WriteLine("Sepete eklendi: " + urun.Fiyati);
            Console.WriteLine("Sepete eklendi: " + urun.Acıklama);
            Console.WriteLine("");
        }


        public void Ekle2(string urunadi, string aciklama, double fiyat, int stokAdedi)
        {




        }


    }
}
