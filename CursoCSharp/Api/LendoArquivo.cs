using System;
using System.IO;

namespace CursoCSharp.Api {
    class LendoArquivo {
        public static void Executar() {
            var path = @"~/lendo_arquivos.txt".ParseHome();

            if (!File.Exists(path)) {
                using (StreamWriter sw = File.AppendText(path)) {
                    sw.WriteLine("t1;t2;t3");
                    sw.WriteLine("caneta;borracha;lapis");
                }
            }

            try {
                using (StreamReader sr = new StreamReader(path)) {
                    var texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                }
            }
            catch (Exception err) {
                Console.WriteLine(err.Message);
            }

        }

    }
}
