

using ClassMetotDemo;

internal class Program
{
    private static void Main(string[] args)
    {
        Musteri m1 = new Musteri();
        m1.Adi = "Yusuf";
        m1.Soyadi = "Yıldız";
        m1.Yas = 23;
        m1.krediPuani = 654.5;


        Musteri m2 = new Musteri();
        m2.Adi = "Yasin";
        m2.Soyadi = "Şahbaz";
        m2.Yas = 33;
        m2.krediPuani = 1354.8;


        Musteri m3 = new Musteri();
        m3.Adi = "Selçuk";
        m3.Soyadi = "Taşkın";
        m3.Yas = 41;
        m3.krediPuani = 1245.8;

        Musteri[] musteris = new Musteri[] { m1, m2, m3 };

        foreach (Musteri m in musteris)
        {
            Console.WriteLine(m.Adi);
            Console.WriteLine(m.Soyadi);
            Console.WriteLine(m.Yas);
            Console.WriteLine(m.krediPuani);
            Console.WriteLine("------");



        }
        Console.WriteLine();                        //Console.WriteLine(musteris); kullanımı neden hata veriyor burada başkanım ekrana yazması lazım değilmi

        MusteriManager musteriManager = new MusteriManager();
        musteriManager.Ekle(m1); // burada musteriManager.Ekle(m1+m2+m3) neden yapamıyoruz baskanım
        musteriManager.Sil(m2);
        musteriManager.Listele(m3);
       
    }
}