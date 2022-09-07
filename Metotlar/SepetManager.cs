using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {

        //naming convention
        public void Ekle(Urun urun) 
        {
            Console.WriteLine("Tebrikler .Sepete eklendi : " + urun.Adi);
        }

        public void Ekle2()                                   //Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi) = DRY UYMUYOR!!
        {
                                                          //Console.WriteLine("Tebrikler .Sepete eklendi : " + urunAdi);  = DRY UYMUYOR!!
        }
    }
}
