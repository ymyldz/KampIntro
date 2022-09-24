using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
     class MusteriManager
    {
        public void Ekle(Musteri m)
        {
            Console.WriteLine("Müşteri eklendi : "  + m.Adi);

       
            
        
        }

   
        public void Sil(Musteri m) 
        {
            Console.WriteLine("Müşteri silindi : " + m.Adi);
      
        }
        public void Listele(Musteri m) 
        {
            Console.WriteLine("\nMüşteriler listelendi" +
                "\n----------------------- " + 
                "\nMüşteri Adı : "+m.Adi+
                "\nMüşteri Soyadı : " + m.Soyadi+
                "\nMüşteri Yaşı : "+m.Yas+ 
                "\nMüşteri Puanı : "+ m.krediPuani);
        }

    }
}
