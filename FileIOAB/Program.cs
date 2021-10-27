using FileIOAB.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOAB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to File IO Operations");
            string path = @"C:\Users\OmSaiRam\Downloads\Practicals\FileIOAB\FileIOAB\FileIO\Sample.txt";
            FileReadWriteOperation file = new FileReadWriteOperation();
            file.FilExists(path);
            file.ReadAllLinesInFile();
            Console.ReadLine();
        }
    }
}
