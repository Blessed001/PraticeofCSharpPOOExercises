using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Pessoa
{
    private string Nome;
    private int Idade;
    private char Genero;
    public static int[] Conta = new int[4];
    public Pessoa()
    {
        Nome = " ";
        Idade = 0;
        Genero = ' ';
    }
    public Pessoa(String N, int I, char G)
    {
        Nome = N;
        Idade = I;
        Genero = G;
    }
    public void Classifica()
    {
        if(Idade < 18)
        {
            if (Genero == 'F')
                Conta[0]++;
            else
                Conta[1]++;       
        }
        else
        {
            if (Genero == 'F')
                Conta[2]++;
            else
                Conta[3]++;
        }
    }
    public static void AfixaContadores()
    {
        string[] G = { "Rapariga", "Rapaz", "Mulher", "Homem" };
        Console.WriteLine();
        for (int i = 0; i <= G.Length - 1; i++)
            Console.WriteLine("{0} --- {1}", G[i], Conta[i]);
    }
}

namespace Exec12PratPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            String Nome;
            int Idade;
            char Genero;

            Pessoa P;
            Console.Write(" Nome ou ZZZ para terminar ? ");
            Nome = Console.ReadLine().ToUpper();
            while (Nome != "ZZZ")
            {
                Console.Write(" Idade ? ");
                Idade = Convert.ToInt16(Console.ReadLine());
                Console.Write("Genero F ou M ? ");
                Genero = Convert.ToChar(Console.ReadLine());
                P = new Pessoa(Nome, Idade, Genero);
                Console.Write(" Nome ou ZZZ para terminar ? ");
                Nome = Console.ReadLine().ToUpper();
                P.Classifica();

            }
            Pessoa.AfixaContadores();
            Console.ReadKey();
            

        }
    }
}
