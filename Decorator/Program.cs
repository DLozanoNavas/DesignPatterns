

using Decorator;

var ps = new PaymentsServiceDecoratorBase(new StripePaymentsService()); // Can be switched to BraintreePaymentsService
ps.ProcessPayment("1234 4567 8901 1234", "12/27", "123");


Console.ReadKey();