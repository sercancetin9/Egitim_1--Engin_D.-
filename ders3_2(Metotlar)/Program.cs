using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders3_2_Metotlar_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5, 6);

            dortIslem.Topla(8, 13);


            Console.ReadLine();
        }

    }

}
