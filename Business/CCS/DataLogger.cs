﻿using System;

namespace Business.CCS
{
    public class DataLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}
