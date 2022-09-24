using OOP3;
using System.Collections.Generic;

IKrediManager ihtiyackredimanager = new IhtıyacKrediManager();

IKrediManager tasıtKrediManager = new TasıtKrediManager();

KonutKrediManager konutKrediManager=new KonutKrediManager();
ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();

BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(konutKrediManager,fileLoggerService);

List<IKrediManager>krediler=new List<IKrediManager>() {ihtiyackredimanager,tasıtKrediManager };
//basvuruManager.KrediOnBilgilendirmesiYap(krediler);
