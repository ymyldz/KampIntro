using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3_demo
{
    internal class FaizsizKredi : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Faizsiz kredi hesaplandı");
        }

        public void Listele()
        {
            throw new NotImplementedException();
        }
    }
}
