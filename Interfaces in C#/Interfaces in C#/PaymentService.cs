using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_in_C_
{
    internal class PaymentService
    {
        private readonly IPaymentProcessor _paymentProcessor;
        public PaymentService(IPaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }

        public void ProcessOrderPayment(decimal amount)
        {
            _paymentProcessor.ProcessPayment(amount);
        }
    }
}
