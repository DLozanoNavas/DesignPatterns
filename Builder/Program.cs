using Builder;

var chickenSandwich = new ChickenSandwich();
var tunaSandwich = new TunaSandwich();

chickenSandwich.BuildSandwich();
tunaSandwich.BuildSandwich();

Console.WriteLine(chickenSandwich.Sandwich);
Console.WriteLine(tunaSandwich.Sandwich);

Console.ReadKey();