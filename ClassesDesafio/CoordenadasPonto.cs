using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosDIO.ClassesDesafio
{
    public class CoordenadasPonto
    {
        /*
        Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).

        Se o ponto estiver na origem, escreva a mensagem “Origem”.

        Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.

        Entrada
        A entrada contem as coordenadas de um ponto

        Exemplo Entrada     |      Saída
        4.5 -2.2            |       Q4
        0.1 0.1             |       Q1
        0.0 0.0             |       Origem
         */

        public static void CoordenadasPontoMain()
        {

            string[] entrada = Console.ReadLine().Split(' ');
            double x = double.Parse(entrada[0]);
            double y = double.Parse(entrada[1]);

            EncontraQuadrante(x, y);

        }

        private static void EncontraQuadrante(double x, double y)
        {

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else if (x > 0.0 && y < 0.0)
            {
                Console.WriteLine("Q4");
            }
        }

    }
    /*
    /////////
    se x > 0 y < 0 == X(+) e Y(-) = Q1
                |+ Y
                |
       Q2       |     Q1
                |
                |0         X
      ------------------------
      -         |           +
                |
        Q3      |     Q4
                |
                |-

    ////////
    */
}
