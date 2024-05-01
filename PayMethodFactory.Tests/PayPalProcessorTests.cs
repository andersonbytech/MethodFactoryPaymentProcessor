using MethodFactoryPaymentProcessor.PaymentProcessors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using MethodFactoryPaymentProcessor.Interfaces;

namespace PayMethodFactory.Tests
{
    public class PayPalProcessorTests
    {
        private readonly Mock<IOutputService> _outputServiceMock;
        private readonly PayPalProcessor _processor;

        public PayPalProcessorTests()
        {
            _outputServiceMock = new Mock<IOutputService>();
            _processor = new PayPalProcessor(_outputServiceMock.Object);
        }

        [Fact]
        public void ProcessPayment_WithValidAmount_ShouldOutputCorrectMessage()
        {
            // Arrange
            var amount = 150m;
            var expectedMessage = $"Processing a PayPal payment of ${amount}";

            // Act
            _processor.ProcessPayment(amount);

            // Assert
            _outputServiceMock.Verify(service => service.Write(expectedMessage), Times.Once());
        }
    }
}

