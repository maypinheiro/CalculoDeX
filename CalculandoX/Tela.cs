using System;
using System.Collections.Generic;
using System.Text;

namespace CalculandoX
{
   public  class Tela
    {
        public string[] RecebeValor()
        {
            var entrada = Console.ReadLine().Replace("=", "+").Split("+");
             string[] valores = entrada;
             return valores;
        }

        public void Imprimir(int valor)
        {
            Console.WriteLine(valor);
        }
    }
}


