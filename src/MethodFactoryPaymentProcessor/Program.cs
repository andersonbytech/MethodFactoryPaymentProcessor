using MethodFactoryPaymentProcessor.Factories;

namespace MethodFactoryPaymentProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the payment method (creditcard, paypal, banktransfer):");
            var paymentMethod = Console.ReadLine();
            Console.WriteLine("Enter the amount to process:");
            var amount = decimal.Parse(Console.ReadLine());

            var processor = PaymentProcessorFactory.GetPaymentProcessor(paymentMethod);
            processor.ProcessPayment(amount);
        }
    }

}
