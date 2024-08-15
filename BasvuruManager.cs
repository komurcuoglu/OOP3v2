using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        {
            //imzaya hangi Manageri girirsek onun hesaplaması çalışır.
            krediManager.Hesapla();
            loggerService.Logger();
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach( var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
       
    }
}
