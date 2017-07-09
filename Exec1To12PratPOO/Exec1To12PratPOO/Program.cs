using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EstudantInf //Create class EstudantInf 
{
    private string Nome;
    private double Teste1;
    private double Teste2;
    public EstudantInf()
    {
        Nome = "";
        Teste1 = 0;
        Teste2 = 0;
    }
    public EstudantInf(string N, double T1, double T2) //Constructor of the class
    {
        Nome = N;
        Teste1 = T1;
        Teste2 = T2;
    }
    public double ClassFinal()// Calculing final classification 
    {
        return Math.Round((Teste1 + Teste2) / 2, 0, MidpointRounding.AwayFromZero);
    }
    public string LerNome() // Metodo leito do name 
    {
        return Nome;
    }
    private static double SomatorioCL = 0;
    private static int Nalunos =0 ;
    public void Somanota()//Soma classificacao final
    {
        SomatorioCL += ClassFinal();
        Nalunos++;
    }
    public static double CalcMedia()//Calcula media da turma
    {
        return Math.Round(SomatorioCL / Nalunos, 2, System.MidpointRounding.AwayFromZero);
    }
    private static int Npositivas = 0;
    public void IncPositivas()//Conta positivas
    {
        if(Teste1 >= 10 || Teste2 >= 10)
        {
            Npositivas++;
        }
    }
    public static int LerPositivas()//Le positivas
    {
        return Npositivas;
    }
    public string SituacaoDoAluno()//Calcula a situacao do aluno
    {
        string Sit;
        double CF = ClassFinal();
        if (CF >= 10)
        {
            Sit = "Aprovado";
        }
        else if (CF >= 8)
        {
            Sit = "Oral";
        }
        else
        {
            Sit = "Reprovado";
        }
        return Sit;
    }
    //Propriedades de leitura e atribuicao 
    public string Pnome
    {
        get { return Nome; }
        set { Nome = value; }
    }
    public double Pteste1
    {
        get { return Teste1; }
        set { Teste1 = value; }
    }
    public double Pteste2
    {
        get { return Teste2; }
        set { Teste2 = value; }
    }
    public void Impressao()//Metodo de impressao
    {
        Console.WriteLine("{0,-20} {1,-8} {2,-8} {3,-10}", "Aluno", "Teste1", "Teste2", "Classificacao");
        Console.WriteLine("{0,-10} {1,12} {2,8} {3,14}", Nome, Teste1, Teste2, ClassFinal());
    }
}


namespace Exe1To12PratPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i;
            Console.Write("Numero de Alunos ? ");
            N = Convert.ToInt16(Console.ReadLine());
            EstudantInf[] A = new EstudantInf[N]; //Vector de objectos do alunos
            for(i = 0; i<=N-1;i++) //Ciclo de insersao de aluno e respectivas notas
            {
                A[i] = new EstudantInf();
                Console.Write("Qual e nome do aluno ? ");
                A[i].Pnome = Console.ReadLine();
                Console.Write("Nota teste 1 ? ");
                A[i].Pteste1 = Convert.ToInt16(Console.ReadLine());
                Console.Write("Nota teste 2 ? ");
                A[i].Pteste2 = Convert.ToInt16(Console.ReadLine());
                A[i].IncPositivas();
            }
            Console.WriteLine("{0} Os alunos tiveram positivas pelo menos num dos tesstes", EstudantInf.LerPositivas());
            Console.ReadKey();
        }
    }
}
