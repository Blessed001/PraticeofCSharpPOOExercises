using System;

namespace Exe19PraPOO
{
    public class ContaCorrente
    {
        private double Valor;
        private char Transacao;
        private static double Saldo = 0;
        private static int NumTrans = 0;

        public ContaCorrente(double V, char T)
        {
            Valor = V;
            Transacao = T;
            NumTransESaldo();
        }
        
        public void NumTransESaldo()
        {
            NumTrans++;
            if (Transacao == 'D')
            
                Saldo += Valor;
                else
                Saldo -= Valor;
            
        }

        public void ImpressaoTransaESaldo()
        {
            Console.WriteLine("Transacao numero {0} ", NumTrans);
            if (Transacao == 'D')
                Console.WriteLine(" {0} de {1} euros ", "Deposito", Valor);
            else
                Console.WriteLine(" {0} de {1} euros ", "Levantamento", Valor);
            Console.WriteLine(" Saldo = {0} euros ", Saldo);
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente C1 = new ContaCorrente(100, 'D');
            C1.ImpressaoTransaESaldo();
            ContaCorrente C2 = new ContaCorrente(50, 'L');
            C2.ImpressaoTransaESaldo();
            ContaCorrente C3 = new ContaCorrente(1000, 'D');
            C3.ImpressaoTransaESaldo();
            ContaCorrente C4 = new ContaCorrente(500, 'L');
            C4.ImpressaoTransaESaldo();
            Console.ReadKey();
        }
    }
}
