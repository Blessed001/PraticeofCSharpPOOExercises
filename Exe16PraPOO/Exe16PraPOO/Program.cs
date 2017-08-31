using System;

namespace Exe16PraPOO
{
    public class Aluno
    {
        private string Nome;
        private int Nota;
        private static int Inf;
        private static int Sup;
        
        public Aluno()//Construtor da class Aluno sem argumentos
        {
            Nome = "";
            Nota = 0;
        }
        public Aluno(string N) //Construtor da class Aluno com o argumento N
        {
            Nome = N;
            int X = 0;
            bool Valida = false;  
            while (Valida == false) //Ciclo While para a validacao de notas
            {
                try
                {
                    Console.WriteLine(" Digite a nota do aluno " + Nome+ " " );
                    X = Convert.ToInt16(Console.ReadLine());
                    Valida = X >= Inf && X <= Sup;
                    if (Valida == false)
                        throw new Exception();
                }
                catch
                {
                    Console.WriteLine(" A nota tem que ser um numero entre {0} e {1}", Inf, Sup);
                }
            }
            Nota = X;
        }

        public static void AtribuicaoLimites(int I, int S)//Metodo de atribucao de limites de nota 
        {
            Inf = I;
            Sup = S;
        }
        public string NomeENota()// Metodo que retorna o nome e a nota valida do aluno
        {
            return Nome + " obteve a classificacao " + Nota;
        }
    }

   public class Program //Programa principal 
    {
        static void Main(string[] args)
        {
            Aluno.AtribuicaoLimites(0, 20);
            Console.WriteLine(" Digite o nome do aluno ... ");
            string N = Console.ReadLine();
            Aluno A = new Aluno(N);
            Console.WriteLine(A.NomeENota());
            Console.ReadKey();
        }
    }
}
