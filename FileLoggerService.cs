﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class FileLoggerService : ILoggerService
    {
        public void Logger()
        {
            Console.WriteLine("File'a loglandı...");
        }
    }
}
