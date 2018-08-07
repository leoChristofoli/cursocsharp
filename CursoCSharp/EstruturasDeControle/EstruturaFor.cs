using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaFor
    {
        public static void Executar() {
            var array = new String[] { "a", "b", "c"};
            var list = new List<int>();

            for(int i=1; i<=10; i++) {
                list.Add(i/2);
            }

            foreach (var number in list) {
                Console.WriteLine(number);
            }
        }
    }
}
