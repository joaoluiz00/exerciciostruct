using System;
using Struct;


namespace exerciciostruct
{
    class Program{
        static void Main(string[]args){

            Equipe equipe = new(2024); // Exemplo de ano de estreia

            equipe.RegistrarCampeonatoVencido(1000); // Exemplo de registro de campeonato vencido com premiação de $1000
            equipe.Imprimir();
  
    }
}
}
