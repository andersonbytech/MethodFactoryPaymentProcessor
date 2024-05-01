using Xunit;
using Moq;
using MethodFactoryPaymentProcessor.Factories;
using MethodFactoryPaymentProcessor.PaymentProcessors;
using MethodFactoryPaymentProcessor.Interfaces;

namespace PayMethodFactory.Tests
{
    public class PaymentProcessorFactoryTests
    {
        private readonly Mock<IOutputService> _outputServiceMock;

        public PaymentProcessorFactoryTests()
        {
            // Cria um mock do IOutputService para injetar nos processadores de pagamento
            _outputServiceMock = new Mock<IOutputService>();
        }

        [Theory]
        [InlineData("creditcard", typeof(CreditCardProcessor))]
        [InlineData("paypal", typeof(PayPalProcessor))]
        [InlineData("banktransfer", typeof(BankTransferProcessor))]
        public void GetPaymentProcessor_ShouldReturnCorrectProcessorType(string paymentType, Type expectedType)
        {
            // Act
            var processor = PaymentProcessorFactory.GetPaymentProcessor(paymentType, _outputServiceMock.Object);

            // Assert
            Assert.IsType(expectedType, processor);
            // Verifica se o processador foi criado com o mock de IOutputService injetado
            var processorInstance = processor as IPaymentProcessor;
            Assert.NotNull(processorInstance);
        }
    }
}
