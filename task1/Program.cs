using System;
using System.IO;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Про программу:
            // Программа работает с 3-мя типами файлов: .txt, .docx, .xlsx;
            // Открывает файл либо создаёт новый с указанным названием.
            // Редактирование файла происходит путём внесения текстовых данных в конец файла;
            // файл не перезаписуется, а дополняется



            // класс FileOne явлеяется, так сказать, общим контейнером для других классов,
            // которые уже работают с каждым типом файла

            FileOne fileOne = new FileOne(); 

            // AstractHandler - абстрактный класс, который имеет в себе методы для работы с файлами
            // (открыть или создать, редактировать)

            AbstractHandler[] typeFile = { new TXT(), new DOCX(), new XLSX() }; 
            foreach (var file in typeFile)
            {
                fileOne.WorkFile(file);
            }
            Console.ReadLine();
        }
    }
}
