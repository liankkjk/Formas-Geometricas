using System;

namespace MACACO
{
    class TrianguloReto : Triangulo
    {
        private double Base;

        public double BaseTri
        {
            get { return Base; }
            set { Base = value; }
        }

        private double altura;
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        private double lado;
        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }

        public override double CalcularArea()
        {
            return (Base * Altura) / 2;
        }

        public override double CalcularPerimetro()
        {
            return lado * 3;
        }

        public override double CalcularHipotenusa()
        {
            return Math.Sqrt((Math.Pow(lado, 2) + Math.Pow(Base, 2))); //mostra a raiz quadrada da soma entre a base e a altura, ambos elevado a 2
        }

        public override string ToString()
        {
            return $"TriânguloReto(Base:{Base}, Altura:{altura}, Lado(s):{lado})";
        }
    }
}
