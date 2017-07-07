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
}


namespace Exe1To12PratPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            EstudantInf A = new EstudantInf("Dionisio", 5, 5); // Instance of new student object 
            Console.WriteLine("{0,-20} {1,-10}","Aluno","Classificacao final"); 
            Console.WriteLine("{0,-20} {1,8}", A.LerNome(), A.ClassFinal()); //Impressao do nome do aluno e a resopectiva classificacao final 
            Console.ReadKey();
        }
    }
}
