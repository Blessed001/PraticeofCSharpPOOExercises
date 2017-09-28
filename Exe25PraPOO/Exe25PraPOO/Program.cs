using System;

namespace Exe25PraPOO
{
    public class Forno
    {
        private double TempForno;
        public Forno()
        {

        }
        public Forno (double TF)
        {
            TempForno = TF;
        }
        public double TForno()
        {
            return TempForno;
        }
    }
    public class Prato
    {
        private double TempPrato;
        private int SegNoForno;
        public Prato ()
        { }
        public Prato (double TP, int S)
        {
            TempPrato = TP;
            SegNoForno = S;
        }
        public double TFinalPrato(double TF)
        {
            return TempPrato += (TF - TempPrato) / 10 * SegNoForno;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Forno F = new Forno(250);
            Prato P = new Prato(15, 15);
            Console.WriteLine("Temperatura final do prato = {0} C", P.TFinalPrato(F.TForno()));
            Console.ReadKey();
        }
    }
}
