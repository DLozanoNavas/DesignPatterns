/*
 * Type: Structural Pattern
 * Purpose: Creates a surrogate to control access to an object.
 * Implementation:
 * Create a wrapper that unifies the use of several other interfaces as members.
 */

// without proxy
Console.WriteLine("Constructing Celebrity.");
var celebrity = new Proxy.Celebrity("Eminem");
Console.WriteLine($"Celebrity approved?: {celebrity.GetApproval()}.");
;

Console.WriteLine();

// with proxy 
Console.WriteLine("Constructing Celebrity Manager proxy.");
var managerProxy = new Proxy.ManagerProxy("Eminem");
Console.WriteLine($"Celebrity approved?: {managerProxy.GetApproval()}.");

Console.WriteLine();

// with chained proxy
Console.WriteLine("Constructing protected BodyGuard proxy.");
var bodyGuardProxy = new Proxy.BodyGuardProxy("Eminem", "knownPerson");
Console.WriteLine($"Celebrity approved?: {bodyGuardProxy.GetApproval()}.");


Console.WriteLine();

// with chained proxy, no access
Console.WriteLine("Constructing protected BodyGuard proxy.");
var bodyGuardProxy2 = new Proxy.BodyGuardProxy("Eminem", "stan");
Console.WriteLine($"Celebrity approved?: {bodyGuardProxy2.GetApproval()}.");

Console.ReadKey();