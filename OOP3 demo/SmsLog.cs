using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3_demo
{
    internal class SmsLog : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms Loglandı");
        }
    }
}
