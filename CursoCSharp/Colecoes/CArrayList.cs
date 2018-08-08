using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes {
    class CArrayList {
        public static void Executar() {
            var arrayList = new ArrayList {
                "string",
                3,
                true
            };

            foreach (var item in arrayList) {
                Console.WriteLine(item.ToString() + " " + item.GetType());
            }
        }
    }
}
