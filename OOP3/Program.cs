using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            IhtiyacKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            ıhtiyacKrediManager.Hesapla();

            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            tasitKrediManager.Hesapla();

            KonutKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();

            Console.WriteLine("--------------------------------");

            //interface lerde intarface i implamente eden classı referans alabilir
            IKrediManager ıhtiyacKrediManager1 = new IhtiyacKrediManager();
            ıhtiyacKrediManager1.Hesapla();

            IKrediManager tasitKrediManager1 = new TasitKrediManager();
            tasitKrediManager1.Hesapla();

            IKrediManager konutKrediManager1 = new KonutKrediManager();
            konutKrediManager1.Hesapla();

            Console.WriteLine("--------------------------------");

            //Başka bir business classı ile de kullanabiliriz bu şekilde kullanılması daha iyi

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            IKrediManager esnafKrediManager = new EsnafKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ıhtiyacKrediManager,databaseLoggerService);
            basvuruManager.BasvuruYap(tasitKrediManager, databaseLoggerService);
            basvuruManager.BasvuruYap(konutKrediManager, fileLoggerService);
            basvuruManager.BasvuruYap(esnafKrediManager, smsLoggerService);

            Console.WriteLine("--------------------------------");

            //List<IKrediManager> krediler = new List<IKrediManager>() 
            //{
            //    ıhtiyacKrediManager,
            //    tasitKrediManager,
            //    konutKrediManager 
            //};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
