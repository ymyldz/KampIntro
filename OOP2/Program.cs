using OOP2;


GercekMusteri musteri1=new GercekMusteri();
musteri1.Id = 1;
musteri1.MusteriNo = "12345";
musteri1.Ad = "Engin";
musteri1.Soyad = "Demiroğ";
musteri1.Tc = "123456789";



//Kodlama.io

TuzelMusteri musteri2=new TuzelMusteri();
musteri2.Id = 3;
musteri2.MusteriNo = "111111";
musteri2.SırketAdı = "Kodlama.io";
musteri2.VergiNo = "1234567890";


//Gerçek Müşteri - Tüzel Müşteri
//SOLID

Musteri musteri3 = new GercekMusteri();
Musteri musteri4 = new TuzelMusteri();
MusteriManager musteriManager=new MusteriManager();
musteriManager.Add(musteri1);
musteriManager.Add(musteri2);
musteriManager.Add(musteri3);
musteriManager.Add(musteri4);   
