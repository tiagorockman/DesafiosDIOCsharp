using System;
namespace DesafiosDIO
{
    public class TempoEvento
    {
        public static void TempoEventoMain(){
            Console.WriteLine("Tempo Evento");

            int diaInicio, diaTermino, horaMomentoInicio, minutoMomentoInicio, segundoMomentoInicio;
            int horaMomentoTermino, minutoMomentoTermino, segundoMomentoTerminio;
            //continue escrevendo a solucao

            string[] dadosInicio = Console.ReadLine().Split();
            diaInicio = Convert.ToInt32(dadosInicio[1]);

            string[] dadosMomentoInicio = Console.ReadLine().Split();
            horaMomentoInicio = Convert.ToInt32(dadosMomentoInicio[0]);
            minutoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[2]);
            segundoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[4]);

            string[] dadosTermino = Console.ReadLine().Split();
            diaTermino = Convert.ToInt32(dadosTermino[1]);

            string[] dadosMomentoTermino = Console.ReadLine().Split();
            horaMomentoTermino = Convert.ToInt32(dadosMomentoTermino[0]);
            minutoMomentoTermino = Convert.ToInt32(dadosMomentoTermino[2]);
            segundoMomentoTerminio = Convert.ToInt32(dadosMomentoTermino[4]);

            DateTime DataInicio = new DateTime(DateTime.Now.Year,DateTime.Now.Month,diaInicio,horaMomentoInicio,minutoMomentoInicio, segundoMomentoInicio);
            DateTime DataFim = new DateTime(DateTime.Now.Year,DateTime.Now.Month,diaTermino,horaMomentoTermino,minutoMomentoTermino, segundoMomentoTerminio);
            int segundosTotais = Math.Abs((int)(DataInicio-DataFim).TotalSeconds); //Retorna total Segundos

            #region TESTE
            //1 hora tem 3600 segundos
          //  int horaInicioSegundos = horaMomentoInicio*3600;
            //1 minuto tem 60 segundos
          //  int minutoInicioSegundos = minutoMomentoInicio*60;

        //int transformaSegundosInicio = (horaInicioSegundos+minutoInicioSegundos+segundoMomentoInicio);
            
          //  int horaTerminoSegundos = horaMomentoTermino*3600;
         //   int minutoTerminoSegundos = minutoMomentoTermino*60;

         //   int transformaSegundosTermino = (horaTerminoSegundos+minutoTerminoSegundos+segundoMomentoTerminio);

          //  int somaTotalSegundos = (transformaSegundosInicio+transformaSegundosTermino);
        #endregion TESTE

            //segundos para dia --> 86.400
            int W =  (int)segundosTotais/(86400);
            var seg_restantes_apos_dias = segundosTotais % 86400;
            //segundos para hora --> 3600 segundos
            int H = (int)(seg_restantes_apos_dias/3600);
            var seg_restantes_apos_hora = segundosTotais % 3600;
            //segundos para minuto --> 60 segundos 
            int M = (int)(seg_restantes_apos_hora/60);
            var seg_restantes_apos_minutos = segundosTotais % 60;
            //segundos
            int S = (int)(seg_restantes_apos_minutos);


            Console.WriteLine("{0} dia(s)", W);
            Console.WriteLine("{0} hora(s)", H);
            Console.WriteLine("{0} minuto(s)", M);
            Console.WriteLine("{0} segundo(s)", S);
        }
    }
}