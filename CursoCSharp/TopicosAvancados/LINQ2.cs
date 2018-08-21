using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CursoCSharp.TopicosAvancados {
    class LINQ2 {
        public static void Executar() {
            var alunos = new List<Aluno> {
                new Aluno(){ Nome = "Pedro", Idade = 20, Nota = 8.0},
                new Aluno(){ Nome = "João", Idade = 19, Nota = 9.1},
                new Aluno(){ Nome = "Ana", Idade = 20, Nota = 8.5},
                new Aluno(){ Nome = "Deiverson", Idade = 21, Nota = 6.0},
                new Aluno(){ Nome = "Julia", Idade = 21, Nota = 9.3},
                new Aluno(){ Nome = "Ana", Idade = 21, Nota = 9.3},
                new Aluno(){ Nome = "André", Idade = 21, Nota = 6.3},
            };

            var pedro = alunos.Single(aluno => aluno.Nome.ToLower().Equals("pedro"));

            var fulano = alunos.SingleOrDefault(aluno => aluno.Nome.ToLower().Equals("fulano"));

            Console.WriteLine(fulano);
            if(fulano == null) {
                Console.WriteLine("Unkown");
            }

            var ana = alunos.FirstOrDefault(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine(ana.Nome);

            var outraAna = alunos.LastOrDefault(aluno => aluno.Nome.Equals("Ana"));

            var ExSkip = alunos.Skip(1).Take(3);

            foreach(var item in ExSkip) {
                Console.WriteLine(item.Nome);
            }

            var menorNota = "";
        }
    }
}
