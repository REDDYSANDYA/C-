
using System;
using System.IO;
using System.IO.Enumeration;
namespace FilesConcept

{
    //The file class from the System.IO namespace,allows us to work with files.
    //File class has many useful methods for creating and getting information about files.

    //Append Text () is used at the end of an existing file.
    //Copy () is used to copy a file.
    //Create () is used to create or overwrite a file.
    //Delete () is used to delete a file.
    //Exists () is used to tests wheather a file is existing or not.
    //ReadAllTexts () is used to read content of the file.
    //Replace () is used to replace the contents of a file to content of another files.
    //WriteAllText () is used to create a new file and writes the content to it,if aleardy file is existing, it will be overwritten.



    internal class Program
    {


        string writeText = "hello world";
        
        string ReadText = File.ReadAllText("filename.txt");
        static void Main(string[] args)
        {
            Console.WriteLine("ReadText");
        }
    }
}
