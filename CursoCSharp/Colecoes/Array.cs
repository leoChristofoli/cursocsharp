using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class Array {
        public static void Executar() {
            // Arrays são estáticos
            string[] alunos = new string[5]; // Estrutura homogenea. Só podem ser armazenados dados do msm tipo
            for (int i=0; i <= 4; i++) {
                alunos[i] = "a" + i.ToString();
            }

            foreach (string x in alunos) {
                Console.WriteLine(x);
            }

            double media;
            double[] notas = { 9.7, 8.9, 8.5, 5.6 };
            
        }
    }
}
