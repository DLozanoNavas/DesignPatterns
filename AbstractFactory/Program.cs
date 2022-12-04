
/*
 * Type: Creation Pattern
 * Purpose: Provide an interface to create families of related or dependent objects without specifying their concrete classes 
 * Implementation:
 * Abstract Products are created by an Abstract Factory & Client Relies on Abstract Factory (so that multiple Concrete Factories can be used)
 * to get Abstract Product implementations (Concrete Products). This way, clients only need to know about the abstractions.
 */

using AbstractFactory;

var spainShoppingCart = new ShoppingCart(new SpainShoppingCartServicesFactory());

var colombiaShoppingCart = new ShoppingCart(new ColombiaShoppingCartServicesFactory());

Console.WriteLine("SPAIN:");
spainShoppingCart.CalculateCost(100);

Console.WriteLine("\nCOLOMBIA:");
colombiaShoppingCart.CalculateCost(100);

Console.ReadKey();