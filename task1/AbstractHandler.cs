using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace task1
{
    abstract class AbstractHandler 
    {
        public abstract void OpenOrCreateFile(); //Открыть существующий файл или создать новый
        public abstract void Edit(); // Редактировать файл
    }
}
