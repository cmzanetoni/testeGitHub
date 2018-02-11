using System;
using System.Globalization;

namespace curso {
    class Tela {
        public static Retangulo lerRetangulo() {
            Console.Write("Altura: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

            Console.Write("Largura: ");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

           return new Retangulo(altura, largura, "vermelho");
        }

        public static Triangulo lerTriangulo() {
            Console.Write("Lado a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Lado b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Lado c: ");
            double c = double.Parse(Console.ReadLine());
            
            return new Triangulo(a, b, c, "vermelho");
        }
    }
}
