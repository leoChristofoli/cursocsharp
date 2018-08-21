using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Api {
    class ExemploTimeSpan {
        public static void Executar() {
            TimeSpan intervalo = new TimeSpan(days: 10, hours: 12, minutes: 25, seconds:10);
            Console.WriteLine(intervalo);
            Console.WriteLine(intervalo.TotalMinutes);

            var largada = DateTime.Now;
            var chegada = largada.AddMinutes(20);

            var tempo = chegada - largada;

            Console.WriteLine(tempo);
            Console.WriteLine(intervalo.Add(TimeSpan.FromMinutes(8)));

            Console.WriteLine("Parse: " + TimeSpan.Parse("01:05:00").TotalSeconds);
        }
    }
}
