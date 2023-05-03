// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Creating and Deleting Files

const string filename = "TestFile.txt";

// TODO: Create a new file - this will overwrite any existing file
// Use the "using" construct to automatically close the file stream
// using (StreamWriter sw = File.CreateText(filename)){
//     sw.WriteLine("This is a test of the file creation system");
// }

// TODO: Determine if a file exists
//Static class method function, File class
Console.WriteLine(File.Exists(filename) );
if (File.Exists(filename)){
    File.Delete(filename);
}
else{
    using (StreamWriter sw = File.CreateText(filename)){
        sw.WriteLine("This is a test of the file creation system");
    }
}
Console.WriteLine(File.Exists(filename) );
