using System;

namespace Exe17PraPOO
{
    public class CartasDejogar
    {
        private int Naipe;
        private int Carta;
        public CartasDejogar()
        {
            Naipe = 0;
            Carta = 0;
        }
        public CartasDejogar(int NR, int VR)
        {
            Naipe = NR;
            Carta = VR;
        }
        static string[] Np = { "Ouro", "Espada", "Paus", "Copas" };
        static string[] Vp = { "2", "3", "4", "5", "6", "7", "Valete", "Dama", "Rei" };
        public string Pnaipe
        {
            get { return Np[Naipe]; }
        }
        public string Pcarta
        {
            get { return Vp[Carta]; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random R = new Random();
            CartasDejogar[] Extraidas = new CartasDejogar[5];
            for (int i = 0; i <= 4; i++)
            {
                Extraidas[i] = new CartasDejogar(R.Next(4), R.Next(9));
                Console.WriteLine(Extraidas[i].Pcarta + " de " + Extraidas[i].Pnaipe);
                Console.ReadKey();
            }
        }
    }
}
