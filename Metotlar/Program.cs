//Dont repeat yourself - DRY - Clean Code - Best Practice

using Metotlar;

Product p1 = new Product();
p1.Adi = "Elma";
p1.Fiyati = 15;
p1.Aciklama = "Amasya Elmasi";

Product p2 = new Product();
p2.Adi = "Karpuz";
p2.Fiyati = 80;
p2.Aciklama = "Diyarbakır Karpuzu";

Product[] ps =new Product[] { p1, p2 };


//type-safe -- tip güvenli
foreach (Product p in ps)
{
    Console.WriteLine(p.Adi);
    Console.WriteLine(p.Fiyati);
    Console.WriteLine(p.Aciklama);
    Console.WriteLine("------------------");

}

Console.WriteLine("-----------------Metotlar----------------");


SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(p1);
sepetManager.Ekle(p2);







