using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_ders1
{
    internal class Program
    {
        static void Main(string[] args)
        { int a = 3;

            if(a==3)
            {
                Console.WriteLine("Hello World");
            }

            Kurs kurs1=new Kurs();

            kurs1.KursAdi = "C#";
            kurs1.Egitmeni = "Engin Demirog";
            kurs1.İzlenmeOrani = 37;

            Kurs kurs2 = new Kurs();

            kurs2.KursAdi = "C44";
            kurs2.Egitmeni = "asdad Demirog";
            kurs2.İzlenmeOrani = 254;

            Kurs kurs3 = new Kurs();

            kurs3.KursAdi = "C55";
            kurs3.Egitmeni = "Engin adfa";
            kurs3.İzlenmeOrani = 8752;

            Kurs kurs4 = new Kurs();

            kurs4.KursAdi = "C++";
            kurs4.Egitmeni = "hagfsadfsfg";
            kurs4.İzlenmeOrani = 55;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (Kurs deneme in kurslar)
            {
                Console.WriteLine("Kurs Adı: "+deneme.KursAdi+ " Eğitmeni: "+deneme.Egitmeni+" İzlenme Oranı: "+deneme.İzlenmeOrani);

            }
            Console.ReadLine();
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmeni { get; set; }

        public int İzlenmeOrani { get; set; }

    }
}
