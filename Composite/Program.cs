/*
 * Type: Structural Pattern
 * Purpose: Compose objects intro tree structures to represent part-whole hierarchies.
 * Implementation:
 * Use object composition to allow for recursive operations on the hierarchical tree.
 */

using Composite;

Console.Title = "Composite Pattern";

var root = new Composite.Folder("root");
var topLevelFile = new Composite.File("notes.txt",10);
var topLevelFolder1 = new Folder("topLevelFolder1");
var topLevelFolder2 = new Folder("topLevelFolder2");

root.Add(topLevelFile);
root.Add(topLevelFolder1);
root.Add(topLevelFolder2);

var subLevelFile1 = new Composite.File("doc.pdf", 200);
var subLevelFile2 = new Composite.File("pic.png", 150);

topLevelFolder2.Add(subLevelFile1);
topLevelFolder2.Add(subLevelFile2);

Console.WriteLine($"Size of topLevelDirectory1: {topLevelFolder1.GetSize()}");
Console.WriteLine($"Size of topLevelDirectory2: {topLevelFolder2.GetSize()}");
Console.WriteLine($"Size of root folder: {root.GetSize()}");

Console.ReadKey();
