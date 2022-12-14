// See https://aka.ms/new-console-template for more information
using Metotlar;

Urun urun1 = new Urun();
urun1.Adi = "elma";
urun1.fiyati = 15;
urun1.Aciklama = "Amasya elması";

Urun urun2 = new Urun();
urun2.Adi = "karpuz";
urun2.fiyati = 80;
urun2.Aciklama = "Diyarbakır karpuzu";

Urun[] urunler = new Urun[] { urun1, urun2 };


foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.fiyati);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine("--------------");
}
//encapsulation(kapsülleme) : urun sayfasına tanımlayıp burada patlamamak yani her sayfada tek tek ekleme yapmaya gerek kalmaz.
//instance- örnek
//dont repeat yourself : kendini tekrar etme
//clear code : temiz kod
//property : özellik


Console.WriteLine("---------Metotlar----------");
Console.WriteLine();
SepetManager SepetManager = new SepetManager();
SepetManager.Ekle(urun1);
SepetManager.Ekle(urun2);


SepetManager.Ekle2("armut","yeşil armut",15,20);
SepetManager.Ekle2("elma", "kırmızı elma", 20,30);
SepetManager.Ekle2("karpuz", "Diyarbakır karpuzu", 80,40);







