using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CursoCSharp.Api {
    class Diretorios {
        public static void Executar() {
            string rootDir = "\\";
            string pythonDir = "intel";
            string pythonPath = Path.Combine(rootDir, pythonDir);
            Console.WriteLine(pythonPath);

            Console.WriteLine("=== DIRS =======");
            var dirs = Directory.GetDirectories(pythonPath, "*", SearchOption.AllDirectories);
            foreach (var dir in dirs) {
                Console.WriteLine(dir);
            }
            Console.WriteLine("\n\n=== FILES ====");
            var files = Directory.GetFiles(rootDir);
            foreach (var file in files) {
                Console.WriteLine(file);
            }
        }
    }
}
