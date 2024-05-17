namespace Struct;

public struct Equipe{
    
    public int numeroCampeonatosVencidos;
    public float valorTotalPremiacoes;
    public int anoEstreia;

    

    public Equipe(int anoEstreia,
     float valorTotalPremiacoes,int numeroCampeonatosVencidos ){
            this.anoEstreia = anoEstreia;
            this.numeroCampeonatosVencidos = numeroCampeonatosVencidos;
            this.valorTotalPremiacoes = valorTotalPremiacoes;
    }

    public Equipe(int anoEstreia)
    {
        numeroCampeonatosVencidos = 0;
        valorTotalPremiacoes = 0;
        this.anoEstreia = anoEstreia;
    }

     public void RegistrarCampeonatoVencido(float valorPremio)
    {
        numeroCampeonatosVencidos++;
        AtualizarValorTotalPremiacoes(valorPremio);
    }
     public void AtualizarValorTotalPremiacoes(float valor)
    {
        valorTotalPremiacoes += valor;
    }
     public bool VerificarAnoEstreia(int anoAtual)
    {
        return anoEstreia == anoAtual;
    }

    public void Imprimir()
    {
        Console.WriteLine($"Número de campeonatos vencidos: {numeroCampeonatosVencidos}");
        Console.WriteLine($"Valor total de premiações: {valorTotalPremiacoes}");
        Console.WriteLine($"Ano de estreia: {anoEstreia}");
    }





}