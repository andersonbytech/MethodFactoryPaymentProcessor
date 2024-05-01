using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using MethodFactoryPaymentProcessor.PaymentProcessors;
using MethodFactoryPaymentProcessor.Interfaces;

namespace PayMethodFactory.Tests
{
    public class BankTransferProcessorTests
    {

        private readonly Mock<IOutputService> _outputServiceMock;
        private readonly BankTransferProcessor _processor;

        public BankTransferProcessorTests()
        {
            _outputServiceMock = new Mock<IOutputService>();
            _processor = new BankTransferProcessor(_outputServiceMock.Object);
        }

        [Fact]
        public void ProcessPayment_WithValidAmount_ShouldOutputCorrectMessage()
        {
            // Arrange
            var amount = 150m;
            var expectedMessage = $"Processing a bank transfer payment of ${amount}";

            // Act
            _processor.ProcessPayment(amount);

            // Assert
            _outputServiceMock.Verify(service => service.Write(expectedMessage), Times.Once());
        }
    }



}


