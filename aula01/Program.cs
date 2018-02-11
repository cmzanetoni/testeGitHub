using System;
using System.Collections.Generic;
using System.Globalization;

namespace curso {
    class Program {
        static void Main(string[] args) {
            List<Figura> figuras = new List<Figura>();

            Console.WriteLine("Quanta figuras você vai calclular?");
            int qtdFiguras = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            for (int i = 1; i <= qtdFiguras; i++) {
                Console.WriteLine("Figura " + i.ToString() + ": triângulo ou retângulo? (t/r)");
                char tipo = char.Parse(Console.ReadLine());

                if (tipo == 'r') {
                    figuras.Add(Tela.lerRetangulo());
                } else {
                    figuras.Add(Tela.lerTriangulo());
                }                
            }

            Console.WriteLine();
            Console.WriteLine("Áreas das figuras:");
            for (int i = 0; i < qtdFiguras; i++) {
                Console.WriteLine("Figura " + i + 1 + " (" + figuras[i].cor + "): " + figuras[i].area());
            }

            Console.ReadLine();
        }
    }
}
