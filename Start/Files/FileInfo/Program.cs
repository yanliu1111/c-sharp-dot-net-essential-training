// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Working with file information
const string filename = "TestFile.txt";

// TODO 1: WriteAllText overwrites a file with the given content
// if (!File.Exists(filename)) {
//     File.WriteAllText(filename, "This is a test file");
// }

// TODO 3: AppendAllText adds text to an existing file
// File.AppendAllText(filename, "This gets appended to the file");

// TODO 4: A FileStream can be opened and written to until closed
// using (StreamWriter sw = File.AppendText(filename)) {
//     sw.WriteLine("Line 1");
//     sw.WriteLine("Line 2");
//     sw.WriteLine("Line 3");
// }

// TODO 2: ReadAllText reads all the content from a file
// string content;
// content = File.ReadAllText(filename);
// Console.WriteLine(content);
// Make sure the example file exists
// const string filename = "TestFile.txt";

if (!File.Exists(filename)) {
    using (StreamWriter sw = File.CreateText(filename)) {
        sw.WriteLine("This is a text file.");
    }
}
File.AppendAllText(filename, "This gets appended to the file");

using (StreamWriter sw = File.AppendText(filename)) {
        sw.WriteLine("This is a Line1");
        sw.WriteLine("This is a Line2.");
        sw.WriteLine("This is a Line3.");
        }

string content;
content = File.ReadAllText(filename);
Console.WriteLine(content);
// TODO: Get some information about the file
// Console.WriteLine(File.GetCreationTime(filename));
// Console.WriteLine(File.GetLastWriteTime(filename));
// Console.WriteLine(File.GetLastAccessTime(filename));

// File.SetAttributes(filename, FileAttributes.ReadOnly);
// Console.WriteLine(File.GetAttributes(filename));


// TODO: We can also get general information using a FileInfo 
try {
    FileInfo fi = new FileInfo(filename);
    Console.WriteLine($"{fi.Length}");
    Console.WriteLine($"{fi.Directory}");
    Console.WriteLine($"{fi.IsReadOnly}");
}
catch (Exception e) {
    Console.WriteLine($"Exception: {e}");
}

// TODO: File information can also be manipulated

DateTime dt = new DateTime(2020, 7, 1);
File.SetCreationTime(filename, dt);
Console.WriteLine(File.GetCreationTime(filename));