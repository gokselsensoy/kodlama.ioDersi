﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2)
        {
            //Topla(2,3)
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç : " + toplam);
        }
        public void Cikarma(int sayi1, int sayi2)
        {
            int cikarma = sayi1 - sayi2;
            Console.WriteLine("Sonuç : " + cikarma);
        }

    }
}
