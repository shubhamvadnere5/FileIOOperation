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

        //Copying existing file in to new one
        public void CopyMethod(string path)
        {
            //It will automatically create new file for write operation
            string destination = @"C:\Users\OmSaiRam\Downloads\Practicals\FileIOAB\FileIOAB\FileIO\Sample.txt";
            try
            {
                File.Copy(path, destination);
                Console.WriteLine("file is copied successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // Delete file -To check whether the file exists or not,If delete the particular file
        public void DeleteFile()
        {
            try
            {
                string deleteFile = @"C:\Users\OmSaiRam\Downloads\Practicals\FileIOAB\FileIOAB\FileIO\Sample.txt";
                if (FilExists(deleteFile))
                {
                    File.Delete(deleteFile);
                    Console.WriteLine("File deleted");
                }
                else
                {
                    Console.WriteLine("File not found!!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // Read from stream reader class-reads a file content one line at a time and displayed it.
        public void ReadFromStreamReader()
        {
            string streamRead = @"C:\Users\OmSaiRam\Downloads\Practicals\FileIOAB\FileIOAB\FileIO\Sample.txt";
            try
            {
                //using keyword is for directing object to garbage collection
                using (StreamReader reader = new StreamReader(streamRead))
                {
                    string line;
                    Console.WriteLine("Read the file from stream reader class");
                    while ((line = reader.ReadLine()) != null)
                    {

                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Write in a file using stream writer class
        public void WriteUsingStreamWriter()
        {
            string streamWritePath = @"C:\Users\OmSaiRam\Downloads\Practicals\FileIOAB\FileIOAB\FileIO\Sample.txt";
            FileStream stream = null;
            try
            {
                stream = new FileStream(streamWritePath, FileMode.OpenOrCreate);
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    writer.WriteLine("Hello World");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (stream != null)
                {
                    stream.Dispose(); //release all resources
                }
            }
            string readText = File.ReadAllText(streamWritePath);
            Console.WriteLine(readText);
        }
    }
}