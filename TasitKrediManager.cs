﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class TasitKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            Console.WriteLine("Taşıt kredisi için birşeyler yapıldı");
        }

        public void Hesapla()
        {
            Console.WriteLine("Taşı kredisi ödeme planı hesaplandı...");
        }
    }
}
