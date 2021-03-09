using System; 
using System.Globalization;

namespace DesafiosDIO
{
    public class MediaPonderada
    {
        /*
            Dado de entrada:
                3.3
                5.0
                Saída esperada:
                MEDIA = 4.45909
        */
        public static void MainMediaPonderada(){

                    Console.WriteLine("Media Ponderada");

                    double notaA, notaB;
                    const double pesoA = 3.5;
                    const double pesoB = 7.5;
                    const double pesoTotal = pesoA + pesoB;
                    notaA = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                    notaB = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                    
                    //A média ponderada é a soma do produto de cada valor pelo seu respectivo peso 
                    //e dividido pelas soma dos pesos.

                    double somaValoresEntradas = (notaA*pesoA) + (notaB*pesoB); 
                    double media = (somaValoresEntradas/ pesoTotal);

                    Console.WriteLine($"MEDIA = {media.ToString("F5", CultureInfo.InvariantCulture)}"); 
        }
    }
}