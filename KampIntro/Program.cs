

namespace KampIntro
{

    class Program
    {

        static void Main(string[] args)

        {
            //type safety - tip güvenliği
            //Do Not Repeat Your Self - kendini tekrarlama
            //değer tutucu - alias
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Notu");
                
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }
           
            if (sistemeGirisYapmisMi)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap butonu");
            }

            Console.Write(kategoriEtiketi);
           



        }

    }


}
