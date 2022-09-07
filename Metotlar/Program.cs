// See https://aka.ms/new-console-template for more information

//don't repeat yourself - DRY - clean code

using Metotlar;

Urun urun1 = new Urun();
urun1.Adi = "Elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya elması";

Urun urun2 = new Urun();
urun2.Adi = "Karpuz";
urun2.Fiyati = 80;
urun2.Aciklama = "Diyarbakır Karpusu";

//array
Urun[] urunler = new Urun[] {urun1, urun2 };

//type-safe
foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine("-----------------");
}

Console.WriteLine("-------------METOTLAR--------------");

//encapsulation8
SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);


