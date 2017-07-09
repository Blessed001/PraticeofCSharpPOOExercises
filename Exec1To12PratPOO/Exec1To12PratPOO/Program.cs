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

    //Construtores de acesso 
    public void EscreverNome(string n)
    {
        Nome = n;
    }
    public void EscreverTeste1(int t1)
    {
        Teste1 = t1;
    }
    public void EscreverTeste2(int t2)
    {
        Teste2 = t2; 
    }
    public void Impressao()//Metodo de impressao
    {
        Console.WriteLine("{0,-20} {1,-8} {2,-8} {3,-10}", "Aluno", "Teste1", "Teste2", "Classificacao");
        Console.WriteLine("{0,-10} {1,12} {2,8} {3,14}", Nome, Teste1, Teste2, ClassFinal());
        Console.ReadKey();
    }
}


namespace Exe1To12PratPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            EstudantInf A = new EstudantInf("Dionisio",5,5); // Instance of new student object 
            A.Impressao();
            
        }
    }
}
