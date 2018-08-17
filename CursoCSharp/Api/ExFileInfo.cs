using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.AccessControl;

namespace CursoCSharp.Api {
    class ExFileInfo {

        public static void ExcluirSeExistir(params string[] caminhos) {
            foreach(var caminho in caminhos) {
                FileInfo arquivo = new FileInfo(caminho);

                if (arquivo.Exists) {
                    arquivo.Delete();
                }
            }
        }

        public static void Executar() {
            var caminhoOrigem = @"~/arq_origem.txt".ParseHome();
            var caminhoDestino = @"~/arq_destino.txt".ParseHome();
            var caminhoCopia = @"~/arq_copia.txt".ParseHome();

            ExcluirSeExistir(caminhoOrigem, caminhoDestino, caminhoCopia);
            
            using (StreamWriter sw = File.CreateText(caminhoOrigem)) {
                sw.WriteLine("Arquivo Original");
            }

            FileInfo origem = new FileInfo(caminhoOrigem);
            Console.WriteLine(origem.Name);
            Console.WriteLine(origem.IsReadOnly);
            Console.WriteLine(origem.FullName);
            Console.WriteLine(origem.LastAccessTime);
            Console.WriteLine(origem.Attributes);

            origem.CopyTo(caminhoCopia);
            origem.MoveTo(caminhoDestino);

        }
    }
}
