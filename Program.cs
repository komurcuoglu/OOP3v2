using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            İhtiyacKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
            TasitKrediManager tasitKrediManager = new   TasitKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();
             */
            
            IKrediManager tasitManager = new TasitKrediManager();
            IKrediManager ihtiyacManager = new İhtiyacKrediManager();
            IKrediManager konutManager = new KonutKrediManager();
            
            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(IKrediManager); IKrediManager interface olduğu için imza olarak verilemez.
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            
            basvuruManager.BasvuruYap(ihtiyacManager,databaseLoggerService);
            basvuruManager.BasvuruYap(konutManager, fileLoggerService);
            basvuruManager.BasvuruYap(tasitManager, fileLoggerService);
            
            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacManager, tasitManager,konutManager };


            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            ILoggerService logger = new FileLoggerService();

          

        }
    }
}