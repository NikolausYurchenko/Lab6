using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace task1
{
    class XLSX : AbstractHandler
    {
        private string fileName = "C:\\Users\\nicky\\source\\repos\\Lab6\\task1\\MyThirdFile.xlsx";
        public override void OpenOrCreateFile()
        {
            using (FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                Console.WriteLine("The File was opened if it was already created earlier;\n" +
                    "The file was created if it did not exist\n");
            }
            Edit();
        }
        public override void Edit()
        {
            Console.WriteLine("If you want to edit this file, enter 1, if not - enter 2");
            string text = Console.ReadLine();
            if (text == "1")
            {
                using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
                {
                    fileStream.Seek(1, SeekOrigin.End);
                    Console.WriteLine("Enter text to write to file:");
                    byte[] buffer1 = System.Text.Encoding.Default.GetBytes(Console.ReadLine());
                    fileStream.Write(buffer1, 0, buffer1.Length);

                    fileStream.Seek(0, SeekOrigin.Begin);
                    byte[] buffer2 = new byte[fileStream.Length];
                    fileStream.Read(buffer2, 0, buffer2.Length);
                    string textFormFile = System.Text.Encoding.Default.GetString(buffer2);
                    Console.WriteLine($"\nText from file: {textFormFile}\n" +
                        $"----- ----- -----\n");
                }
            }
            else
            {
                if (text == "2")
                {
                    Console.WriteLine("End\n" +
                        "----- ----- -----\n");
                }
                else
                {
                    throw new Exception("Error: You pressed wrong info\n" +
                        "----- ----- -----\n");
                }
            }
        }
    }
}
