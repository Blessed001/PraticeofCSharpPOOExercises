using System;

namespace Exe22PraPOO
{
    public class RaizQuad
    {
        public RaizQuad()
        { }
        public int RaizQ (int x)
        {
            return (int)Math.Sqrt(x);
        }
        public double RaizQ (double x)
        {
            return Math.Round(Math.Sqrt(x),2);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            RaizQuad R = new RaizQuad();
            int x = 49;
            double y = 22.50;
            Console.WriteLine("Raiz quadrada de {0} = {1}", x, R.RaizQ(x));
            Console.WriteLine("Raiz quadrada de {0} = {1}", y, R.RaizQ(y));
            Console.ReadKey();
        }
    }
}
