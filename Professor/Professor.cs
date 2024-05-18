using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public struct Professor
{
    public string Nome { get; set; }
    public string Departamento { get; set; }
    public int Idade { get; set; }
    public string Email { get; set; }
    public List<string> Cursos { get; set; }
    public decimal Salario { get; set; }
    public int CargaHoraria { get; set; }

    public Professor(string nome, string departamento, int idade, string email, List<string> cursos, decimal salario, int cargaHoraria)
    {
        Nome = nome;
        Departamento = departamento;
        Idade = idade;
        Email = email;
        Cursos = cursos;
        Salario = salario;
        CargaHoraria = cargaHoraria;
    }


    public void ReajustarSalario(decimal valor)
    {
        Salario += valor;
    }

    public void DescontarPorFalta(int faltas, decimal valorPorFalta)
    {
        Salario -= faltas * valorPorFalta;
    }

    public void AumentarCargaHoraria(int horas, decimal valorPorHora)
    {
        CargaHoraria += horas;
        Salario += horas * valorPorHora;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Departamento: {Departamento}");
        Console.WriteLine($"Idade: {Idade}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine("Cursos: " + string.Join(", ", Cursos));
        Console.WriteLine($"Salário: {Salario:C}");
        Console.WriteLine($"Carga Horária: {CargaHoraria} horas");
    }
    public void Imprimir()
    {
        string informacoes = $"Nome: {Nome}\n" +
                             $"Departamento: {Departamento}\n" +
                             $"Idade: {Idade}\n" +
                             $"Email: {Email}\n" +
                             $"Cursos: {string.Join(", ", Cursos)}\n" +
                             $"Salário: {Salario:C}\n" +
                             $"Carga Horária: {CargaHoraria} horas\n";
        Console.WriteLine(informacoes);
    }
}

class Program
{
    static void Main(string[] args)
    {
        var cursos = new List<string> { "Matemática", "Física" };
        Professor professor = new Professor("João Silva", "Ciências Exatas", 45, "joaopedro01032006@gmail", cursos, 3000.00m, 40);

        Console.WriteLine("Informações iniciais:");
        professor.ExibirInformacoes();
        
        professor.ReajustarSalario(500.00m);
        Console.WriteLine("\nApós reajuste salarial:");
        professor.ExibirInformacoes();

        professor.DescontarPorFalta(2, 100.00m);
        Console.WriteLine("\nApós descontar por faltas:");
        professor.ExibirInformacoes();

        professor.AumentarCargaHoraria(5, 50.00m)   ;
        Console.WriteLine("\nApós aumentar a carga horária:");
        professor.ExibirInformacoes();

        professor.Imprimir();
        Console.WriteLine("\nImprimir");
        professor.ExibirInformacoes();
    }
}
