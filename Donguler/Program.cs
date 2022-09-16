// See https://aka.ms/new-console-template for more information





string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
string kurs2 = "Programlamaya başlangıç için temel kurs";
string kurs3 = "Java";

//array - dizi 

string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs", "Java", "Python","C++"};


//Console.WriteLine(kurs1);yanlıs kullanım



for (int i = 0; i < kurslar.Length; i++) //i=i+2 program dili 0 dan sayar 0 1 2 diye
{
    Console.WriteLine(kurslar[i]);
}

Console.WriteLine("For bitti");


foreach (string kurs in kurslar)  //for intin kolay kullanımı
{
    Console.WriteLine(kurs);
}


Console.WriteLine("sayfa sonu - footer");