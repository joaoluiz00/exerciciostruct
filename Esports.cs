using System;
using Struct;


namespace exerciciostruct
{
    class Program{
        static void Main(string[]args){

            Equipe equipe = new(2024); // Exemplo de ano de estreia

            equipe.RegistrarCampeonatoVencido(1000); // Exemplo de registro de campeonato vencido com premiação de $1000
            equipe.Imprimir();

            Jogador jogador1 = new();

            jogador1.nome = "Neymar";
            jogador1.idade = 17;
            jogador1.altura = "1.72";
            jogador1.clube = "Santos";

            jogador1.numeroCartoesAmarelos = 7;
            jogador1.numeroCartoesVermelhos = 3;


            Console.WriteLine(jogador1.imprimir());
  
    }
}
}
