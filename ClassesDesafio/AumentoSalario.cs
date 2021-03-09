using System; 
using System.Globalization;

namespace DesafiosDIO
{
    public class AumentoSalario
    {
     /*   Dado de entrada:
        9230.01
        Saída esperada:
        Novo salario: 9599.21
        Reajuste ganho: 369.20
        Em percentual: 4 %
     */
        public static void MainAumentoSalario()
        {
            Console.WriteLine("Aumento Salario");

            double salario = -1, reajuste = 0.00, novoSalario = 0.00, percentual = 0;
            salario = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                       //insira os valores corretos de acordo com o enunciado
            if(salario < 0.00){
              return;
            }
            else if(salario >= 0.00 && salario <= 400.00)
            {
                percentual = 15;
                reajuste = salario * ((double)percentual / 100); 
                novoSalario = salario + reajuste;
                
            }
            else if (salario > 400.00 && salario <= 800.00)
            {
                percentual = 12;
                reajuste = salario * ((double)percentual / 100); 
                novoSalario = salario + reajuste;
            }
            else if (salario > 800.00 && salario <= 1200.00)
            {
                 percentual = 10;
                reajuste = salario * ((double)percentual / 100); 
                novoSalario = salario + reajuste;
            }
            else if (salario > 1200.00 && salario <= 2000.00)
            {
                percentual = 7;
                reajuste = salario * ((double)percentual / 100); 
                novoSalario = salario + reajuste;
            }
            else
            {
              percentual = 4;
              reajuste = salario * ((double)percentual / 100); 
              novoSalario = salario + reajuste;
            
            }
            
             Console.WriteLine($"Novo salario: {novoSalario.ToString("F2", CultureInfo.InvariantCulture)}");
             Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2", CultureInfo.InvariantCulture)}");
             Console.WriteLine($"Em percentual: {percentual} %");
        }      
    }
}
