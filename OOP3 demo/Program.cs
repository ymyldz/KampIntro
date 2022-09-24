using OOP3_demo;

IKrediManager sifirfaizlikredi = new SifirFaizliKredi();
IKrediManager hicfaizsizkredi = new HicFaizsizKredi();
IKrediManager faizsizkredi=new FaizsizKredi();
ILoggerService smslog = new SmsLog();
ILoggerService filelog = new FileLog();

sifirfaizlikredi.Hesapla();
smslog.Log();


List<IKrediManager> krediler = new List<IKrediManager>() {sifirfaizlikredi,hicfaizsizkredi,faizsizkredi };
List<ILoggerService> loggers = new List<ILoggerService>() { smslog, filelog };

BasvuruManager basvuruManager=new BasvuruManager();
basvuruManager.BasvuruYap(faizsizkredi, smslog);

sifirfaizlikredi.Hesapla();


