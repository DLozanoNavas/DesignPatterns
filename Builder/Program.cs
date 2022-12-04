using Builder;
/*
 * Type: Creation Pattern
 * Purpose: Use when you need to separate the construction of a complex object from it's representation,
 * so that the same construction process can create different representations.
 * Implementation:
 * - Builder defines an abstraction to create a Concrete (or abstract) Product that can vary depending on the Concrete Builder used.
 */

var chickenSandwichBuilder = new ChickenSandwich(); // Using Chicken Concrete Builder
chickenSandwichBuilder.BuildSandwich();
Console.WriteLine(chickenSandwichBuilder.Sandwich);

var tunaSandwichBuilder = new TunaSandwich(); // Using Tuna Concrete Builder
tunaSandwichBuilder.BuildSandwich();
Console.WriteLine(tunaSandwichBuilder.Sandwich);

ISandwichBuilder sandwichBuilder = new ChickenSandwich(); // Then can be switched!
sandwichBuilder.BuildSandwich();
Console.WriteLine(sandwichBuilder.Sandwich);

Console.ReadKey();