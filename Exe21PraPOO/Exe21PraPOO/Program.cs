using System;

namespace Exe21PraPOO
{
    public class Amigo
    {
        private string Nome;
        private string Apelido;
        public Amigo(string N, string A)
        {

            Nome = N;
            Apelido = A;

        }
        public override string ToString()
        {
            return Apelido + " , " + Nome;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Amigo A = new Amigo("Dionisio", "Chiquengue");
            Console.WriteLine(A.ToString());
            Console.ReadKey();
        }
    }
}
