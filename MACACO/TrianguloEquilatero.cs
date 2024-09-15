using System;

namespace MACACO
{
    class TrianguloEquilatero : Triangulo
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
            return (Math.Sqrt(3) / 4) * Math.Pow(lado, 2);
        }

        public override double CalcularPerimetro()
        {
            return lado * 3;
        }

        public override double CalcularHipotenusa()
        {
            return 0; //equilatero não tem como calcular a hipotenusa
        }

        public override string ToString()
        {
            return $"TriânguloEquilatero(Base:{Base}, Altura:{altura}, Lado(s):{lado})";
        }
    }
}
