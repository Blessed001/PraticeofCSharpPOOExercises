using System;

namespace Exe15PraPOO
{
    public class Viagem
    {
        private double KmInicio;
        private double LInicio;
        private double KmFim;
        private double LFim;
        public Viagem()//Construtor sem argumentos
        {
            KmInicio = 0;
            KmFim = 0;
            LInicio = 0;
            LFim = 0;
        }
        public Viagem(double KmIn, double LIn)//Construtor com argumentos
        {
            KmInicio = KmIn;
            LInicio = LIn;
            KmFim = 0;
            LFim = 0;
        }
        public void LeituasFinais(double KmFi,double LFi) //Metodo Leituras finais
        {
            KmFim = KmFi;
            LFim = LFi;
        }
        public double ConsumoLitros()//Metodo que calcula o consumo de litros
        {
            return (LInicio - LFim) * 100 / (KmFim - KmInicio);
        }
        public double ConsumoValor(double Preco)//Metodo consumo de valores 
        {
            return ConsumoLitros() * Preco;
        }
    }

   public class Program
    {
        static void Main(string[] args)
        {
            Viagem V = new Viagem(10000, 45);
            V.LeituasFinais(12000, 5);
            Console.WriteLine("O consumo medio aos 100 Km = {0} litros", V.ConsumoLitros());
            Console.WriteLine("O consumo medio aos 100 Km = {0} Euros",V.ConsumoValor(1.1));
            Console.ReadKey();
        }
    }
}
