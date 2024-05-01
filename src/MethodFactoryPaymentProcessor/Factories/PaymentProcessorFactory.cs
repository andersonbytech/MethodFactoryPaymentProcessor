using MethodFactoryPaymentProcessor.Interfaces;
using MethodFactoryPaymentProcessor.PaymentProcessors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodFactoryPaymentProcessor.Factories
{
    public class PaymentProcessorFactory
    {
        public static IPaymentProcessor GetPaymentProcessor(string paymentType, IOutputService outputService)
        {
            switch (paymentType.ToLower())
            {
                case "creditcard":
                    return new CreditCardProcessor(outputService);
                case "paypal":
                    return new PayPalProcessor(outputService);
                case "banktransfer":
                    return new BankTransferProcessor(outputService);
                default:
                    throw new ArgumentException("Invalid payment type");
            }
        }
    }


}
