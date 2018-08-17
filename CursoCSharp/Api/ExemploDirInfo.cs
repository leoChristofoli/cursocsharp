using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CursoCSharp.Api {
    class ExemploDirInfo {
        public static void Executar() {
            var dirPython = @"c:\python27";

            var dirInfo = new DirectoryInfo(dirPython);

            if (!dirInfo.Exists) {
                dirInfo.Create();
            }

            var arquivos = dirInfo.GetFiles("*.*", SearchOption.AllDirectories);
            foreach (var arquivo in arquivos) {
                Console.WriteLine(arquivo.Name + " | " + arquivo.LastWriteTime);
            }
        }
    }
}
