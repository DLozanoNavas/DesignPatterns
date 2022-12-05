using Adapter;
/*
 * Type: Structural Pattern
 * Purpose: Use when need to adapt some object to produce another.
 * Implementation:
 * Target consumes the target which uses the Adapter to adapt the adaptee
 */


Console.Title = "Adapter Pattern";

var client = new Client(new CityAdapter());
client.UseCity();

Console.ReadKey();