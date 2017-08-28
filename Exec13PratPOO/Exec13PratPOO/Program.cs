using System;

namespace Exec13PratPOO
{
    public class Triangulo
    {
        private double Base;
        private double Altura;
        public Triangulo()
        {
            Base = 0;
            Altura = 0;
        }
        public Triangulo(double B, double H)
        {
            Base = B;
            Altura = H;
        }
        public double Area()
        {
            return Base * Altura / 2;
        }
        public double[] Ampliacao(double X)
        {
            double[] Medidas = new double[2];
            Medidas[0] = Base * X;
            Medidas[1] = Altura * X;
            return Medidas;
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            Triangulo T = new Triangulo(4, 5);
            Console.WriteLine("Area ={0}", T.Area());
            double[] Med = new double[2];
            Med = T.Ampliacao(3);
            Console.WriteLine("Base ampliada = {0}", Med[0]);
            Console.WriteLine("Altura amoliada = {0}", Med[1]);
            Console.ReadKey();
        }
    }
}

