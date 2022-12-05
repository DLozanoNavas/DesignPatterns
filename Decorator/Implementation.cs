using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// Component 
    /// </summary>
    public interface IPaymentsService
    {
        bool ProcessPayment(string creditCardNumber, string crefirCardExpiration, string CVC);
    }
    /// <summary>
    /// Concrete Component
    /// </summary>
    public class StripePaymentsService : IPaymentsService
    {
        public bool ProcessPayment(string creditCardNumber, string crefirCardExpiration, string CVC)
        {
            Console.WriteLine("Processing Payment through Stripe");
            return true;
        }
    }
    /// <summary>
    /// Concrete Component
    /// </summary>
    public class BraintreePaymentsService : IPaymentsService
    {
        public bool ProcessPayment(string creditCardNumber, string crefirCardExpiration, string CVC)
        {
            Console.WriteLine("Processing Payment through Braintree");
            return true;
        }
    }
    /// <summary>
    /// Decorator
    /// </summary>
    public class PaymentsServiceDecoratorBase : IPaymentsService
    {
        private IPaymentsService PaymentsService { get; set; }

        public PaymentsServiceDecoratorBase(IPaymentsService paymentsService)
        {
            PaymentsService = paymentsService;
        }

        public virtual bool ProcessPayment(string creditCardNumber, string crefirCardExpiration, string CVC)
        {
            return PaymentsService.ProcessPayment(creditCardNumber, crefirCardExpiration, CVC);
        }
    }
}
