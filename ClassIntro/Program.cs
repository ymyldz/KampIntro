
string adi = "Yusuf";
int yas = 22;

Kurs kurs1 = new Kurs();
kurs1.KursAdi = "C#";
kurs1.KursunEgitmeni = "Engin Demiroğ";
kurs1.IzlenmeOrani = 68;

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "java";
kurs2.KursunEgitmeni = "yusuf";
kurs2.IzlenmeOrani = 78;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "python";
kurs3.KursunEgitmeni = "ahmet";
kurs3.IzlenmeOrani = 80;

Console.WriteLine(kurs1.KursAdi + " " + kurs1.KursunEgitmeni);

Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};

foreach (Kurs kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi + " : " + kurs.KursunEgitmeni);
}

product urun1 = new product();
urun1.AyakabiAdi = "nike";
urun1.AyakabiRengi = "kırmızı";
urun1.AyakabiNumarasi = 24;

product urun3 = new product();
urun3.AyakabiAdi = "adidas";
urun3.AyakabiRengi = "mor";
urun3.AyakabiNumarasi = 35;

product urun2 = new product();
urun2.AyakabiAdi = "newbalance";
urun2.AyakabiRengi = "turuncu";
urun2.AyakabiNumarasi = 42;

product[] urunler = new product[] {urun1,urun2,urun3};

foreach (product urun in urunler)
{
   Console.WriteLine(urun.AyakabiAdi + " : " + urun.AyakabiRengi + " : " + urun.AyakabiNumarasi);
}


























class product
{ 
    public string AyakabiAdi { get; set; } 
    public int AyakabiNumarasi { get; set; }

    public string AyakabiRengi { get; set; }
}




class Kurs
{
    public string KursAdi { get; set; }
    public string KursunEgitmeni { get; set; }
    public int IzlenmeOrani { get; set; }
}