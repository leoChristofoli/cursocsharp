﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CursoCSharp.TopicosAvancados {

    public class Aluno {
        public string Nome;
        public int Idade;
        public double Nota;
    }

    class LINQ1 {
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

            Console.WriteLine("===== Aprovados ==========");

            var aprovados = alunos.Where(a => a.Nota >= 7).OrderBy(a => -a.Nota);

            foreach (var aluno in aprovados) {
                Console.WriteLine(aluno.Nome);
            }

            Console.WriteLine("====== Nomes ======");

            var nomes = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
            foreach (var nome in nomes) {
                Console.WriteLine(nome);
            }

            var alunosAprovados =
                from aluno in alunos
                where aluno.Nota >= 7
                orderby aluno.Idade
                select aluno.Nome;
        }
    }
}
