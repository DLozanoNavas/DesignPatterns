using Adapter;

Console.Title = "Adapter Pattern";

var client = new Client(new CityAdapter());
client.UseCity();

Console.ReadKey();