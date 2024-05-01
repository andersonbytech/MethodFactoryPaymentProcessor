using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using MethodFactoryPaymentProcessor.PaymentProcessors;

namespace PayMethodFactory.Tests
{
    public class BankTransferProcessorTests
    {
        [Fact]
        public void ProcessPayment_WithValidAmount_ShouldOutputCorrectMessage()
        {
            // Arrange
            var processor = new BankTransferProcessor();
            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            processor.ProcessPayment(100m);

            // Assert
            var expected = "Processing a Bank Transfer payment of $100\r\n";
            Assert.Equal(expected, output.ToString());
        }
    }
}


