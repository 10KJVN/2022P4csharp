using System;
using System.IO;
namespace FileIOOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Text = File.ReadAllLines(@"C:\Users\Jahva\MA\f1m4\2022P4csharp\Csharp2Opdrachten\FileIOOpdracht\iotext.txt");

            foreach (string Line in Text)
                Console.WriteLine(Line);
        }
    }
}