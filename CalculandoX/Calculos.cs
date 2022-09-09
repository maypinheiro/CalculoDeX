using System;
using System.Collections.Generic;
using System.Text;

namespace CalculandoX
{
   public class Calculos
    {

        public int Equacao(string[] valores)
        {


            if (valores[0] == "EOF")
                return 99999;

            else if (valores[0] == "R")
            {
                int calculo = int.Parse(valores[2]) - int.Parse(valores[1]);
                return calculo;
            }
            else if (valores[1] == "L")
            {
                int calculo = int.Parse(valores[0]) - int.Parse(valores[2]);
                return calculo;
            }
            else if (valores[2] == "J")
            {
                int calculo = int.Parse(valores[0]) + int.Parse(valores[1]);
                return calculo;
            }

            else
            {
                return 99999;
            }
        }

    }
}