using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class Array {
        public static void Executar() {
            // Arrays são estáticos
            string[] alunos = new string[5]; // Estrutura homogenea. Só podem ser armazenados dados do msm tipo
            for (int i=0; i < alunos.Length; i++) {
                alunos[i] = "a" + i.ToString();
            }

            foreach (string x in alunos) {
                Console.WriteLine(x);
            }

            double somatorio = 0;
            double media;
            double[] notas = { 9.7, 8.9, 8.5, 5.6 };

            foreach( double nota in notas) {
                somatorio += nota;
            }

            media = somatorio / notas.Length;

            Console.WriteLine($"media {media}");

            char[] palavra = { 'W', 'o', 'r', 'd' };
            string word = new string(palavra);

            Console.WriteLine(word);
            
        }
    }
}
