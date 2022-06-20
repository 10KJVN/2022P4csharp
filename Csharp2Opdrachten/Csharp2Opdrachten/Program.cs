using System;
using System.IO;
namespace FileDirOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Jahva\MA\f1m4\GD\2022P4csharp\Csharp2Opdrachten\Csharp2Opdrachten");
            Console.WriteLine("No search pattern returns:");
            foreach (DirectoryInfo fil in dir.GetDirectories())
            {
                Console.WriteLine(fil.Name);
            }

            Console.WriteLine();

            foreach (FileInfo fil in dir.GetFiles())
            {
                Console.WriteLine(fil.Name);
            }

        }
    }
}