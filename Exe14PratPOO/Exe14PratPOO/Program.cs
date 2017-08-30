using System;

namespace Exe14PratPOO
{
    public class Temperatura
    {
        private double C;
        private double F;
        public Temperatura()
        {
            C = 0;
            F = 32;
        }
        public Temperatura(double C)
        {
            this.C = C;
            F =Math.Round(C * 1.8 + 32,0,MidpointRounding.AwayFromZero);
        }
        public void ImprimirTemp()
        {
            Console.WriteLine("{0} Celsius = {1} Fahrenheit ", C, F);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Temperatura T = new Temperatura(30);
            T.ImprimirTemp();
            Console.ReadKey();
        }
    }
}
