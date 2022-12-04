/*
 * Type: Creation Pattern
 * Purpose: Use common interface/class to create an object to let subclasses decide which class to instantiate.
 * Implementation:
 * ConcreteProducts <- Product & ConcreteCreators <- Creator
 * This way, clients only need to know about Product & Creator.
 */

using Factory;

var f1 = new CountryTaxFactory("COL");
var f2 = new StateTaxFactory("FL");

var s1 = f1.CreateTaxService();
var s2 = f2.CreateTaxService();

Console.WriteLine($"Tax: {s1.Tax}% from {f1}");
Console.WriteLine($"Tax: {s2.Tax}% from {f2}");

Console.ReadKey();