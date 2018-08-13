using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {

    public abstract class Celular {
        public abstract string Assistente();

        public string Tocar() {
            return "Trim trim...";
        }
    }

    public class IPhone : Celular {
        public override string Assistente() {
            return "Siri";
        }
    }

    public class Samsung : Celular {
        public override string Assistente() {
            return "Bixb";
        }
    }

    class CAbstract {
        public static void Executar() {
            var celulares = new List<Celular> {
                new IPhone(),
                new Samsung()
            };

            foreach (var celular in celulares) {
                Console.WriteLine(celular.Assistente());
                Console.WriteLine(celular.Tocar());
            }
        }
    }
}
