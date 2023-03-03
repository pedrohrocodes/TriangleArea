using System;
using System.Globalization;

namespace Triangle {
    class Program {
        static void Main(string[] args) {
            var triangleX = new Triangle();
            var triangleY = new Triangle();

            Console.WriteLine("Entre com as medidas do triângulo X:");
            triangleX.SetSideA(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            triangleX.SetSideB(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            triangleX.SetSideC(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            triangleY.SetSideA(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            triangleY.SetSideB(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            triangleY.SetSideC(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));


            double areaX = triangleX.CalculateArea();
            double areaY = triangleY.CalculateArea();

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY) {
                Console.WriteLine("Maior área: X");
            } else {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}
