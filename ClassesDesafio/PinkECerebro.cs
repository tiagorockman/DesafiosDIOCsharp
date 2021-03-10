using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosDIO.ClassesDesafio
{
    class PinkECerebro
    {
        /*
         Desafio
            Pink e Cérebro dividem um apartamento e estão juntos 24h por dia desde o começo da pandemia. Para passar o temp, Pink cria problemas matemáticos para Cérebro resolver, o último deles foi uma lista de números com a seguinte pergunta: quantos números da lista são múltiplos de 2, 3, 4 e 5?

            Apesar de parecer simples, porém, quando a lista contém muitos números, Cérebro se confunde e acaba errando alguns cálculos.

            Ajude Cérebro a resolver o desadio de Pink.

            Entrada
            A primeira linha da entrada consiste em um inteiro N (1 ≤ N ≤1000), representando a quantidade de números na lista de Pink.

            A segunda linha contém N inteiros Li (1 ≤ Li ≤ 100), representando os números da lista de Pink.

            Saída
            Imprima a quantidade de números múltiplos de 2, 3, 4 e 5 presentes na lista. Observe a formatação da saída nos exemplos, pois ela deve ser seguida rigorosamente.
                ENTRADA                 |               SAIDA
                5                       |       4 Multiplo(s) de 2
                2 5 4 20 10             |       0 Multiplo(s) de 3
                                                2 Multiplo(s) de 4
                                                3 Multiplo(s) de 5

         */
        public static void PinkECerebroMain()
        {
            int qtdNumeros = int.Parse(Console.ReadLine());
            if (qtdNumeros > 1000)
                throw new IndexOutOfRangeException();

            string[] arrayNumeros = Console.ReadLine().Split(" ");

            VerificaMultiplos(arrayNumeros);


        }

        private static void VerificaMultiplos(string[] arrayNumeros)
        {
            int multiploDeDois = 0, multipoDeTres = 0, multiploDeQuatro = 0, multiploDeCinco = 0;
            int[] numeros = arrayNumeros.Select(n => int.Parse(n)).ToArray();

            foreach(int numero in numeros)
            {
                if (numero % 2 == 0)
                    multiploDeDois++;

                if (numero % 3 == 0)
                    multipoDeTres++;

                if (numero % 4 == 0)
                    multiploDeQuatro++;

                if (numero % 5 == 0)
                    multiploDeCinco++;
            }

            Console.WriteLine($"{multiploDeDois} Multiplo(s) de 2");
            Console.WriteLine($"{multipoDeTres} Multiplo(s) de 3");
            Console.WriteLine($"{multiploDeQuatro} Multiplo(s) de 4");
            Console.WriteLine($"{multiploDeCinco} Multiplo(s) de 5");

        }
    }
}
