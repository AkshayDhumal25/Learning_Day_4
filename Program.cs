using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Net.Mime;
namespace CSharpFuncamentals
{
    class Program
    {
        static void Main(string[] args)
        {

            //// File and FileInfo
            //var path = @"c:\somefile.jpg";
            //File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            //File.Delete(path);
            //if (File.Exists(path))
            //{
            //    //
            //}
            //var content = File.ReadAllText(path);

            //var fileInfo = new FileInfo(path);
            //fileInfo.CopyTo("...");
            //fileInfo.Delete();
            //if (fileInfo.Exists)
            //{
            //    //
            //}

            // Directory and DirectoryInfo
            //Directory.CreateDirectory(@"c:\temp\folder1");
            //var files =  Directory.GetFiles(@"C:\Users\Dell\source\repos\Learning_Day_4", "*.*", SearchOption.AllDirectories);
            ////foreach(var file in files)
            ////{
            ////    Console.WriteLine(file);
            ////}

            //var directories = Directory.GetDirectories(@"C:\Users\Dell\source\repos\Learning_Day_4", "*.*", 
            //    SearchOption.AllDirectories);
            //foreach(var directory in directories)
            //{
            //    Console.WriteLine(directory);
            //}
            //Directory.Exists("...");

            //var directoryInfo = new DirectoryInfo("...");
            //directoryInfo.GetFiles();
            //directoryInfo.GetDirectories();


            //*************** Path **********************
            //var path = @"C:\Users\Dell\source\repos\Learning_Day_4\Learning_Day_4.sln";
            //var dotIndex = path.IndexOf('.');
            //var extension = path.Substring(dotIndex);

            //Console.WriteLine("Extension: " + Path.GetExtension(path));

            //*************** Assessment File & Directories ***************
            //1-Write a program that reads a text file and displays the number of words.
            //var path = @"C:\Users\Dell\Downloads\MyName.txt";
            //var content = File.ReadAllText(path);

            //string[] words = content.Split(new char[] { ' ', '\n', '\t', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            //var count = words.Length;
            //Console.WriteLine(count);


            //2- Write a program that reads a text file and displays the longest word in the file.
            //var path = @"C:\Users\Dell\Downloads\MyName.txt";
            //var text = File.ReadAllText(path);
            //string[] words = text.Split(new char[] { ' ', '\t', '\r', '\n' });
            //var longestWord = "";
            //foreach(var word in words)
            //{
            //    if(word.Length > longestWord.Length)
            //    {
            //        longestWord = word;
            //    }
            //}
            //Console.WriteLine(longestWord);


        }
    }
}