using System;

namespace MACACO
{
    class TrianguloIsosceles : Triangulo
    {

        private double altura;

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        private double Base;

        public double BaseTri
        {
            get { return Base; }
            set { Base = value; }
        }

        private double lado;

        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }

        public override double CalcularArea()
        {
            return (Base * altura) / 2;
        }

        public override double CalcularPerimetro()
        {
            return lado * 3;
        }

        public override double CalcularHipotenusa()
        {
            return Math.Sqrt((Math.Pow(lado, 2) + Math.Pow(Base, 2))); 
        }

        public override string ToString()
        {
            return $"TriânguloIsosceles(Base:{Base}, Altura:{altura}, Lado(s):{lado})";
        }
    }
}
