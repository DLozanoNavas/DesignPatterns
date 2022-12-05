using Decorator;

Console.Title = "Decorator Pattern";

/*
 * Type: Structural Pattern
 * Purpose: Attach additional responsibilities to an object (not to a class).
 * Implementation:
 * Use wrappers to add new methods and properties.
 */


var ps = new PaymentsServiceDecoratorBase(new StripePaymentsService()); // Can be switched to BraintreePaymentsService
ps.ProcessPayment("1234 4567 8901 1234", "12/27", "123");


Console.ReadKey();