
using Prototype;

Console.Title = "Prototype Pattern";

var manager = new Manager("Anna");
var managerClone = (Manager)manager.ShallowClone();
Console.WriteLine($"Manager was cloned: {managerClone.Name}");


var employee = new Employee("John", managerClone);
var employeeClone = (Employee)employee.DeepClone()!;
Console.WriteLine($"Employee was cloned: {employeeClone.Name} with manager {employeeClone.Manager.Name}");


Console.WriteLine($"{employeeClone.Name}'s Manager is {employeeClone.Manager.Name}");
managerClone.Name = "Carlos";
Console.WriteLine($"{employeeClone.Name}'s Manager is {employeeClone.Manager.Name}");

Console.ReadKey();