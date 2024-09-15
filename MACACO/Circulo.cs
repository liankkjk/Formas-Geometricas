using System;

namespace MACACO
{
    class Circulo : FormaGeometrica
    {
        private double raio;

        public double Raio
        {
            get { return raio; }
            set { raio = value; }
        }

        public override double CalcularArea()
        {
            return 3.14 * Math.Pow(raio,2);
        }

        public override double CalcularPerimetro()
        {
            return 2 * 3.14 * raio;
        }

        public override string ToString()
        {
            return $"Circulo (Raio da circunferência:{raio})";
        }
    }
}
