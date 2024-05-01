using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodFactoryPaymentProcessor.Interfaces
{
    public interface IOutputService
    {
        void Write(string message);
    }
}
