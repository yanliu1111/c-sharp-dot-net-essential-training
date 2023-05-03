﻿// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Creating and Deleting Directories

const string dirname = "TestDir";

// TODO: Create a Directory if it doesn't already exist
// if (!Directory.Exists(dirname)) {
//     Directory.CreateDirectory(dirname);
// }
// else {
//     Directory.Delete(dirname);
// }

// TODO: Get the path for the current directory
string curpath = Directory.GetCurrentDirectory();
// Console.WriteLine($"Current directory is {curpath}");

// TODO: Just like with files, you can retrieve info about a directory
// DirectoryInfo di = new DirectoryInfo(curpath);
// Console.WriteLine($"{di.Name}");
// Console.WriteLine($"{di.Parent}");
// Console.WriteLine($"{di.CreationTime}");

// TODO: Enumerate the contents of directories
Console.WriteLine("Just directories:");
List<string> thedirs = new List<string>(Directory.EnumerateDirectories(curpath));
foreach (string dir in thedirs) {
    Console.WriteLine(dir);
}
Console.WriteLine("---------------");

Console.WriteLine("Just files:");
thedirs = new List<string>(Directory.EnumerateFiles(curpath));
foreach (string dir in thedirs) {
    Console.WriteLine(dir);
}
Console.WriteLine("---------------");

Console.WriteLine("All directory contents:");
thedirs = new List<string>(Directory.EnumerateFileSystemEntries(curpath));
foreach (string dir in thedirs) {
    Console.WriteLine(dir);
}

