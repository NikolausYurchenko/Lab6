using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class FileOne
    {
        public void WorkFile(AbstractHandler typeFile)
        {
            typeFile.OpenOrCreateFile();
        }
    }
}
