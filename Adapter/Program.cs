using Adapter;
/*
 * Type: Structural Pattern
 * Purpose: Use when need to adapt some object to produce another.
 * Implementation:
 * Target Consumes Adapter to adapt the adaptee
 * This way, clients only need to know about Product & Creator.
 */


Console.Title = "Adapter Pattern";

var client = new Client(new CityAdapter());
client.UseCity();

Console.ReadKey();