using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Net.Mime;
using System.Security.Cryptography.X509Certificates;
namespace CSharpFuncamentals
{
    //class Program
    //{
        // static void Main(string[] args)
        // {

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


        //**********************Debugging************

        //    var numbers = new List<int> { 1, 2};
        //    var smallests = GetSmallests(numbers, 3);

        //    foreach (var number in smallests)
        //    {
        //        Console.WriteLine(number);
        //    }


        //}

        //public static List<int> GetSmallests(List<int> list, int count)
        //{
        //    var tempList = new List<int>(list); // Make a copy of the list to avoid modifying the original
        //    var smallests = new List<int>();

        //    while (smallests.Count < count && tempList.Count > 0)
        //    {
        //        var min = tempList.Min(); // Get the smallest value
        //        smallests.Add(min);
        //        tempList.Remove(min); // Remove the smallest value from tempList
        //    }

        //    return smallests;




        //*************** String InterPolation **************
        //int n1 = 10;
        //int n2 = 30;
        //string s = "";
        //Console.WriteLine("Sum : " + (n1+n2));  // We need use the bracket for the addition otherwise it'll only concatenate the numbers.

        //Console.WriteLine("The sum of {0} and {1} is {2}",n1,n2,n1+n2);//preferable

        //// String interpolation
        //Console.WriteLine($"The sum of {n1} and {n2} using INTERPOLATION is {n1 + n2}");
        //Console.WriteLine(string.IsNullOrEmpty(s));



        // Revision of previously done things
        //Second Largest Element from an Array
        //Console.WriteLine("Enter the Size of Array: ");
        //var n = Convert.ToInt32(Console.ReadLine());
        //int[] array = new int[n];
        //Console.WriteLine("Enter the elements of Array: ");
        //for(var i = 0; i < n; i++)
        //{
        //    var temp = Convert.ToInt32(Console.ReadLine());
        //    array[i] = temp;
        //    temp = 0;
        //}
        //var maxElement = 0;
        //var secMax = 0;
        //foreach(var i in array)
        //{
        //    if (array[i] >= maxElement)
        //    {
        //        secMax = maxElement;
        //        maxElement = array[i];

        //    }
        //    if (array[i] < maxElement && array[i] > secMax)
        //    {
        //        secMax = array[i];
        //    }
        //}
        //Console.WriteLine($"Second Maximum element is {secMax}");

        // Check the string is palindrome or not
        //    Console.WriteLine("Enter the word to check Palindrome or Not :");
        //    var word = Console.ReadLine();

        //    if (isPalindrome(word))
        //    {
        //        Console.WriteLine("Palindrome");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Not Palindrome");
        //    }

        //}
        //public static bool isPalindrome(string word)
        //{
        //    var left = word[0];
        //    var right = word.Length - 1;
        //    var isPalindrome = true;
        //    while (left < right)
        //    {
        //        if (word[left] != word[right])
        //        {
        //            return false;
        //        }

        //        left++;
        //        right--;
        //    }
        //    return true;
        // }
        //static void Main()
        //{
        //    Console.WriteLine("Enter the word to check Palindrome or Not:");
        //    var word = Console.ReadLine();

        //    if (IsPalindrome(word))
        //        Console.WriteLine("Palindrome");
        //    else
        //        Console.WriteLine("Not Palindrome");
        //}

        //public static bool IsPalindrome(string word)
        //{
        //    int left = 0;
        //    int right = word.Length - 1; // Fix: Last valid index

        //    while (left < right)
        //    {
        //        if (word[left] != word[right]) // Fix: Compare characters correctly
        //            return false;

        //        left++;
        //        right--;
        //    }
        //    return true;
        //}

        //Strings Try with you knowledge
        //Convert An integer to string
        //public static void Main(string[] args)
        //{
        //    int i = 123;
        //    string s = i.ToString();
        //    Console.WriteLine("Conversion of int to string : "+ s);
        //    // Formatting
        //    string text = "Akshay Dhumal   ";
        //    string uppercase = text.ToUpper();
        //    Console.WriteLine("Used the ToUpper() Function : " + uppercase);
        //    string lowercase = text.ToLower();
        //    Console.WriteLine("Used the ToLower() Function : " + lowercase);
        //    string toTrim = text.Trim();
        //    Console.WriteLine("Trimed Text : " + toTrim);

        //    //Searching
        //    var index = text.IndexOf('A');
        //    Console.WriteLine($"Index of A : {index}");
        //    var lastindex = text.LastIndexOf(text);
        //    Console.WriteLine($"Last index ot the input : {lastindex}");
            

        //}
        //static void Main(string[] args)
        //{
        //    var sentence = "This is going to bea really really really really long text...";
        //    const int maxLength = 20;

        //    if(sentence.Length < maxLength)
        //    {
        //        Console.WriteLine(sentence);
        //    }
        //    else
        //    {
        //        var words = sentence.Split(' ');
        //        var totalcharacters = 0;
        //        var summarywords = new List<string>();
        //        foreach(var word in words)
        //        {
        //            summarywords.Add(word);
        //            totalcharacters += word.Length + 1;
        //            if(totalcharacters > maxLength)
        //            {
        //                break;
        //            }

        //        }
        //        var summary = string.Join(" ", summarywords) + "...";
        //        Console.WriteLine(summary);
        //    }
        //}

        //


    //}
       

    //********* Inheritance (Diaond Problem)    //class Program
    //{
    //    class A
    //    {
    //        public virtual void Print()
    //        {
    //            Console.WriteLine("A Implementation");

    //        }

    //    }
    //    class B : A
    //    {
    //        public override void Print()
    //        {
    //            Console.WriteLine("B Implementation");
    //        }
    //    }
    //    class C : A
    //    {
    //        public override void Print()
    //        {
    //            Console.WriteLine("C Implementation");
    //        }
    //    }
    //    class D : B, C
    //    {

    //    }
    //    public static void Main()
    //    {
    //        D d = new D();
    //        d.Print();
    //    }
    //}

    public class Employee
    {
        public string FirstName;
        public string LastName;

        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
    public class FullTimeEmployee : Employee
    {

    }
    public class PartTimeEmployee : Employee
    {
        public new void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " - Contractor");
        }
    }

    public class Program
    {
        public static void Main()
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Akshay";
            FTE.LastName = "Dhumal";
            FTE.PrintFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "Atharva";
            PTE.LastName = "Shinde";
            PTE.PrintFullName();
        }
    }
}