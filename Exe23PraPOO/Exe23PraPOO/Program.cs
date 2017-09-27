using System;

namespace Exe23PraPOO
{
    public class Carro
    {
        private string Nomepro;
        private int Ano;
        private double NumKm;
        public Carro()
        {

        }
        public Carro(string N, int A, int K)
        {
            Nomepro = N;
            Ano = A;
            NumKm = K;
        }
        public string Comparacao(int AnoCorrente, Carro Outro)
        {
            string MaisKm = "O carro de " + this.Nomepro;
            MaisKm += " tem maior quilometragem media";
            double EsteMedKm = this.NumKm / (AnoCorrente - this.Ano);
            double OutroMedKm = Outro.NumKm / (AnoCorrente - Outro.Ano);
            if(EsteMedKm < OutroMedKm)
            {
                MaisKm = "O carro de " + Outro.Nomepro;
                MaisKm += " tem maior quilometragem media ";
            }
            else if (EsteMedKm == OutroMedKm)
            {
                MaisKm = " Os dois carros tem a mesma quilometragem media ";   
            }
            return MaisKm;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Carro A = new Carro("Dionisio", 2000, 10000);
            Carro B = new Carro("Claudio", 1989, 15000);
            Console.WriteLine(A.Comparacao(2010, B));
            Console.ReadKey();
            
        }
    }
}
