using Bridge;

Console.Title = "Bridge Pattern";

/*
 * Type: Structural Pattern
 * Purpose: Decouple an abstraction from its implementation so that the two can vary independently.
 * Implementation:
 * Abstraction defines the abstraction´s interface and holds a reference to the Implementor.
 */

var cart = new ItalyCart(new TenPercentCoupon());

cart.CalculateTotal();

Console.ReadKey();