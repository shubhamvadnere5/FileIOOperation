using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOAB.FileIO
{
    class FileReadWriteOperation
    {
        public bool FilExists(string path)
        {
            //File is a class
            if (File.Exists(path))
            {
                Console.WriteLine("File exists");
                return true;
            }
            else
            {
                Console.WriteLine("File not exists");
                return false;
            }
        }

        //Method to read all lines in a file 
        public void ReadAllLinesInFile()
        {
            try
            {
                string[] lines;
                string path = @"C:\Users\OmSaiRam\Downloads\Practicals\FileIOAB\FileIOAB\FileIO\Sample.txt";
                //Reads all lines in file one by one 
                lines = File.ReadAllLines(path);
                if (lines.Length != 0)
                {
                    foreach (var i in lines)
                    {
                        Console.WriteLine(i + " ");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Method to read all texts from the file
        public void ReadAllTextInFile()
        {
            try
            {
                string text;
                string path = @"C:\Users\OmSaiRam\Downloads\Practicals\FileIOAB\FileIOAB\FileIO\Sample.txt";
                //Read all lines in a file at once
                text = File.ReadAllText(path);
                if (text.Length != 0)
                {
                    Console.WriteLine(text);
                }
                else
                {
                    Console.WriteLine("File does not contain any text");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}