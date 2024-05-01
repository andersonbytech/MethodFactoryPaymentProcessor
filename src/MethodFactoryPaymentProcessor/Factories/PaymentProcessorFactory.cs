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
        public static IPaymentProcessor GetPaymentProcessor(string paymentType)
        {
            switch (paymentType.ToLower())
            {
                case "creditcard":
                    return new CreditCardProcessor();
                case "paypal":
                    return new PayPalProcessor();
                case "banktransfer":
                    return new BankTransferProcessor();
                default:
                    throw new ArgumentException("Invalid payment type");
            }
        }
    }

}
