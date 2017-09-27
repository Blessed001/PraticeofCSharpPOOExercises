using System;

namespace Exe24PraPOO
{
    public class Disciplina
    {
        private string Desig;
        private static int SomaNotas;
        private static int NumAlunos;
        public Disciplina (string Desc, int N)
        {
            Desig = Desc;
            SomaNotas += N;
            NumAlunos++;
        }
        public static double MediaTotal()
        {
            return (double)SomaNotas / NumAlunos;
        }

    }  
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma nota de informatica (-1 para terminar)");
            int Nota = Convert.ToInt16(Console.ReadLine());
            while (Nota >= 0)
            {
                Disciplina I = new Disciplina("Informatica", Nota);
                Console.WriteLine("Digite uma nota de Informatica (-1 para terminar)");
                Nota = Convert.ToInt16(Console.ReadLine());  
            }
            Console.WriteLine("Digite uma nota de Matematica (-1 para terminar)");
            Nota = Convert.ToInt16(Console.ReadLine());
            while(Nota >= 0)
            {
                Disciplina M = new Disciplina("Matematica", Nota);
                Console.WriteLine("Digite uma nota de Matematica (-1 para terminar)");
                Nota = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("Classificacao media das duas disciplinas " + "{0, 2:F2}", Disciplina.MediaTotal());
            Console.ReadKey();

        }
    }
}
