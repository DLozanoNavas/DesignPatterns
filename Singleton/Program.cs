using Singleton;

/*
 * Type: Creation Pattern
 * Purpose: Use when you only need one instance of a class.
 * Implementation:
 * - Static Instance Prop  + Backing field
 * - private/protected constructor
 * - Lazy<t> to make it thread safe
 */



Console.Title = "Singleton Demo";

// var a = new Logger(); // Won´t work because constructor is not accessible.

Logger.Instance.Log("Niceeee! right?... right?");

// Well, let's test out
var l1 = Logger.Instance;
var l2 = Logger.Instance;

if (l1 == l2 && l2 == Logger.Instance)
{
    Console.WriteLine("Instances are the same");
}

l1.Log($"Hi from {nameof(l1)}");
l2.Log($"Hi from {nameof(l2)}");

// Thread Safe Implementation
Logger.LazyInstance?.Log($"Hi from  {nameof(Logger.LazyInstance)}");


Console.ReadLine();
