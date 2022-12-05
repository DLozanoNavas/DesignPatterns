
using System.Runtime.Serialization;
using Facade;

Console.Title = "Facade Pattern";

/*
 * Type: Structural Pattern
 * Purpose: Group a set of system interfaces into a unified interface wrapper to provide an abstraction that's easier to use.
 * Implementation:
 * Create a wrapper that unifies the use of several other interfaces as members.
 */

var cart = new Cart(15);

var facade = new CartsServiceFacade();
Console.WriteLine($"Cart Discount is: {facade.CalculateDiscountPercentage(cart)}%");

Console.ReadKey();