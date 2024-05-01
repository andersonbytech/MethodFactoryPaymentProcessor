using MethodFactoryPaymentProcessor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodFactoryPaymentProcessor.PaymentProcessors
{
    public class BankTransferProcessor : IPaymentProcessor
    {
        private readonly IOutputService _outputService;

        public BankTransferProcessor(IOutputService outputService)
        {
            _outputService = outputService;
        }

        public void ProcessPayment(decimal amount)
        {
            _outputService.Write($"Processing a bank transfer payment of ${amount}");
        }
    }

}
