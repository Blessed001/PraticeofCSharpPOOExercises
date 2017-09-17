using System;

namespace Exe20PraPOO
{
    public class ContaCorrente2
    {
        private double Valor;
        private char Transacao;
        private bool Valida;
        private static double Saldo = 0;
        private static int NumTrans = 0;

        public ContaCorrente2(double V, char T)
        {
            if (Validar(V,T) == true)
            {
                Valida = true;
                NumTrans++;
                Valor = V;
                Transacao = T;
                NumTransESaldo();
            }
            
        }

        public static bool Validar(double V, char T)
        {
            if (T == 'L' && V > Saldo)
                return false;
            else
                return true;
        }

        public void NumTransESaldo()
        {
            if (Transacao == 'D')

                Saldo += Valor;
            else
                Saldo -= Valor;

        }

        public void ImpressaoTransaESaldo()
        {
            if (Valida == false)
                Console.WriteLine("Transacao anulada ", NumTrans);
            else
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
            ContaCorrente2 C1 = new ContaCorrente2(100, 'D');
            C1.ImpressaoTransaESaldo();
            ContaCorrente2 C2 = new ContaCorrente2(1000, 'L');
            C2.ImpressaoTransaESaldo();
            ContaCorrente2 C3 = new ContaCorrente2(200, 'D');
            C3.ImpressaoTransaESaldo();
            ContaCorrente2 C4 = new ContaCorrente2(350, 'L');
            C4.ImpressaoTransaESaldo();
            Console.ReadKey();
        }
    }
}
