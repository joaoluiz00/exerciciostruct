namespace Struct
{
    public struct Jogador
    {
        public string nome;
        public int idade;
        public string altura;
        public string clube;
        public int numeroCartoesAmarelos;
        public int numeroCartoesVermelhos;

        public Jogador(string nome, int idade, string altura, string clube)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
            this.clube = clube;
            this.numeroCartoesAmarelos = 0; 
            this.numeroCartoesVermelhos = 0; 
        }

        public void registrarNumeroCartoesAmarelos(int quantidade)
        {
            this.numeroCartoesAmarelos += quantidade;
        }

        public void registrarNumeroCartoesVermelhos(int quantidade)
        {
            this.numeroCartoesVermelhos += quantidade;
        }
        public bool verificarVinculoClube()
        {
            
            return (this.clube ?? "") != "";
        }


        public string imprimir()
        {
            return "Nome: " + this.nome +
                   "\nIdade: " + this.idade +
                   "\nAltura: " + this.altura +
                   "\nClube: " + this.clube +
                   "\nNúmero de Cartões Amarelos: " + this.numeroCartoesAmarelos +
                   "\nNúmero de Cartões Vermelhos: " + this.numeroCartoesVermelhos;
        }
    }
}