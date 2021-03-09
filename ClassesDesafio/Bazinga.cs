using System;
namespace DesafiosDIO
{
    /* ENUNCIADO
    Em um episódio da aclamada série The Big Ban Theor dois pernagens, Sheldon e Raj, discutem qual dos dois é o melhor: o filme Saturn 3 ou a série Deep Space 9. A sugestão de Raj para a resolução do impasse é uma disputa de Pedra-Papel-Tesoura. Contudo, Sheldon argumenta que, se as partes envolvidas se conhecem, entre 75% e 80% das disputas de Pedra-Papel-Tesoura terminam empatadas, e então sugere o Pedra-Papel-Tesoura-Lagarto-Spock.

        As regras do jogo proposto são:

        a tesoura corta o papel;
        o papel embrulha a pedra;
        a pedra esmaga o lagarto;
        o lagarto envenena Spock;
        Spock destrói a tesoura;
        a tesoura decapita o lagarto;
        o lagarto come o papel;
        o papel contesta Spock;
        Spock vaporiza a pedra;
        a pedra quebra a tesoura.
        Conhecendo os personagens, sabemos que caso Sheldon vencesse, ele gritaria a vitória com um "Bazinga!". Se Raj vencesse, Sheldon o acusaria de ter trapaceado. Agora, se desse empate, Sheldon não descansaria e insistira para jogarem de novo até que seja decidido. Sabendo dessas ações, faça um programa que imprima a provável reação de Sheldon.
    */
    /*
    3 --> Quantidade de entrada
    papel pedra --> opção Sheldon e Raj
        Dado de entrada:
        3
        papel pedra
        lagarto tesoura
        Spock Spock
        Saída esperada:
        Caso #1: Bazinga!
        Caso #2: Raj trapaceou!
        Caso #3: De novo!
    */
    public class Bazinga
    {
        public static void BazingaMain(){
            Console.WriteLine("Bazinga");
            int qtdTeste = int.Parse(Console.ReadLine());
            string v1, v2;
            for (int i = 1; i <= qtdTeste; i++) //insira a variavel correta
            {
                string[] valores = Console.ReadLine().Split();
                v1 = valores[0].ToString().ToLower();
                v2 = valores[1].ToString().ToLower();
                if((v1=="tesoura" && v2=="papel") || (v1=="papel" && v2=="pedra") //complete a solução
                    || ( v1=="pedra" && v2=="lagarto" ) || ( v1=="lagarto" && v2=="spock")
                    || ( v1=="spock" && v2=="tesoura" ) || ( v1=="tesoura" && v2=="lagarto")
                    || ( v1=="lagarto" && v2=="papel" ) || ( v1=="papel" && v2=="spock")
                    || ( v1=="spock" && v2=="pedra"   ) || ( v1=="pedra" && v2=="tesoura"))
                    Console.WriteLine("Caso #{0}: Bazinga!", i);                
                else if (v1==v2)   //complete a solucao
                    Console.WriteLine("Caso #{0}: De novo!", i);
                else
                    Console.WriteLine("Caso #{0}: Raj trapaceou!", i);
            }
        }
    }
}