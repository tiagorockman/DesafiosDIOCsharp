using System;
using System.Globalization;
namespace DesafiosDIO
{
    public class CrescimentoPopulacional
    {
        /*
            No exemplo abaixo representa:
            8 --> Quantidade de registros
            100 --> Populacao cidade A
            1100000 --> Poupulacao cidade B
            7.1 --> Taxa de crescimento populacional cidade A (%)
            1.0 --> Taxa de crescimento populacional cidade B (%)

            Saída
            Imprima, para cada caso de teste, quantos anos levará para que a cidade A 
            ultrapasse a cidade B em número de habitantes.

            Dado de entrada:
            8 
            100 1100000 7.1 1.0
            500 56866 5.0 3.5
            654327 894521 8.4 3.2
            100 199 3.0 0.0
            190 200 0.2 0.1
            666 6660 10.0 9.0
            696 6969 1.9 1.8
            101 103 .5 .2
            Saída esperada:
            Mais de 1 seculo.
            Mais de 1 seculo.
            7 anos.
            27 anos.
            Mais de 1 seculo.
            Mais de 1 seculo.
            Mais de 1 seculo.
            Mais de 1 seculo.
        */
        public static void CrescimentoPopMain(){
            Console.WriteLine("Crescimento Populacional.");

                 int t = Convert.ToInt32(Console.ReadLine());
            double[] arrayList = new double[4];
            int pa, pb;
            double cpa, cpb;
            int anos;

            for (int i = 0; i < t; i++)
            {
                anos = 0;
                string[] valores = Console.ReadLine().Split();
                pa = int.Parse(valores[0]);
                pb = int.Parse(valores[1]);

               //declare as variaveis corretamente
                cpa = double.Parse(valores[2], CultureInfo.InvariantCulture); //decimal
                cpa /= 100; //transforma para percentagem
                cpb = double.Parse(valores[3], CultureInfo.InvariantCulture);
                cpb /=100;

                while (pa <= pb)
                {

                    pa += (int)(pa *cpa); //incrementa a populacao de acordo com 
                    pb += (int)(pb *cpb); // a porcentagem de aumento convertido para inteiro
                    anos++;

                    if (anos > 100)
                    {
                      Console.WriteLine("Mais de 1 seculo.");
                      break;
                       //complete a condicional
                    }
                }

                if (anos <= 100)
                {
                  Console.WriteLine($"{anos} anos.");
                }

            }
        }
    }
}