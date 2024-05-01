﻿using MethodFactoryPaymentProcessor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodFactoryPaymentProcessor.Services
{
    public class ConsoleOutputService : IOutputService
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }

}
