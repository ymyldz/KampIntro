using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3_demo
{
    internal class HicFaizsizKredi : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Hiç faizsiz kredi hesaplandı");
        }

        public void Listele()
        {
            throw new NotImplementedException();
        }
    }
}
