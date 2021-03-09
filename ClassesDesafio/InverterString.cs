using System;
using System.Linq;
namespace DesafiosDIO
{
    public class InverterString
    {
        public static void InverterStringMain(){
            Console.WriteLine("Inverter String");
             string n = Console.ReadLine();
             string textoInvertivo = new string(n.Reverse().ToArray());
            Console.WriteLine(textoInvertivo);
            Console.ReadLine();
        }
    }
}