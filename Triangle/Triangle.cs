using System;

namespace Triangle {
    // Classe não anêmica
    public class Triangle {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public Triangle() {

        }

        public Triangle(double a, double b, double c) {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public void SetSideA(double a) {
            this.A = a;
        }

        public void SetSideB(double b) {
            this.B = b;
        }

        public void SetSideC(double c) {
            this.C = c;
        }

        public double CalculateArea() {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
