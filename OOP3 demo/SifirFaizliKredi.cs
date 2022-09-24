using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3_demo
{
    internal class SifirFaizliKredi : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Sıfır faizli kredi hesaplandı");
        }

        public void Listele()
        {
            throw new NotImplementedException();
        }
    }
}
