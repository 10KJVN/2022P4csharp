using System;
using System.IO;
namespace FileIOOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringText = File.ReadAllText(@"C:\Users\Jahva\MA\f1m4\GD\2022P4csharp\StringOpdracht\stringsplit.txt");
            string[] text = stringText.Split(':', ',');

            foreach (string tekst in text)
            {
                Console.WriteLine(tekst);
            }
        }
    }
}