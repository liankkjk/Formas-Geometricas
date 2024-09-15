namespace MACACO
{
    class Retangulo : FormaGeometrica
    {
        private double altura;

        private double Base;

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public double BaseRet
        {
            get { return Base; }
            set { Base = value; }
        }

        public override double CalcularArea()
        {
            return Base * altura;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (Base + altura);
        }

        public override string ToString()
        {
            return $"Retângulo (Base:{Base}, Altura:{altura})";
        }
    }
}
