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
            Console.WriteLine("Müşteriler listelendi : " + 
                "Müşteri Adı : "+m.Adi+
                "Müşteri Soyadı : " + m.Soyadi+
                "Müşteri Yaşı : "+m.Yas+ 
                "Müşteri Puanı"+ m.krediPuani);
        }

    }
}
