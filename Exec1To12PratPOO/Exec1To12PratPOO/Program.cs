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
}


namespace Exe1To12PratPOO
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
