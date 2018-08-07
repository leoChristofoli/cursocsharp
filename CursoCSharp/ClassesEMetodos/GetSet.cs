using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Moto {
        private string Marca; //Private é o padrão
        private string Modelo;
        private int Cilindrada;

        public Moto(string marca, string modelo, int cilindrada) {
            //Marca = marca;
            //Modelo = modelo;
            //Cilindrada = cilindrada;

            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);
        }

        public Moto() {

        }

        public string GetMarca() {
            return Marca;
        }

        public string GetModelo() {
            return Modelo;
        }

        public int GetCilindrada() {
            return Cilindrada;
        }

        public void SetMarca(string marca) {
            Marca = marca;
        }

        public void SetModelo(string modelo) {
            Modelo = modelo;
        }

        public void SetCilindrada(int cilindrada) => Cilindrada = Math.Abs(cilindrada);
        //if (cilindrada > 0) {
        //    Cilindrada = cilindrada;
        //}
        //else {
        //    Cilindrada = 1;
        //}

        public override string ToString() => Marca + " " + Modelo + " " + Cilindrada;

    }

    class GetSet
    {
        public static void Executar() {
            var moto1 = new Moto(
                    marca: "Ducati",
                    cilindrada: 659,
                    modelo: "Panigale"
                );
            Console.WriteLine(moto1);
        }
    }
}
