using System;

namespace CalculandoX
{
    class Program
    {
        static void Main(string[] args)
        {
           
            while (true)
            {
                Tela tela = new Tela();
                Calculos calculos = new Calculos();
                var total = calculos.Equacao(tela.RecebeValor());
                tela.Imprimir(total);

                if (total == 99999)
                {
                    Console.Clear();
                    Environment.Exit(0);
                }
            }

        }
    }
}
