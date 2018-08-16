using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Excecoes {

    public class Conta {
        double Saldo;

        public Conta(double saldo) {
            Saldo = saldo;
        }

        public void Sacar(double valor) {
            if (valor > Saldo) {
                throw new ArgumentException("Saldo insuficiente.");
            }
            Saldo -= valor;
        }
    }

    class PrimeiraExcecao {
        public static void Executar() {
            var conta = new Conta(1_600);

            try {
                conta.Sacar(1500);
                Console.WriteLine("Sucesso");
            }
            catch (ArgumentException err) {
                Console.WriteLine(err.GetType().Name);
            }
            catch (Exception err) {
                Console.WriteLine(err.Message);
            }
            finally {
                Console.WriteLine("Fim");
            }
        }
    }
}
