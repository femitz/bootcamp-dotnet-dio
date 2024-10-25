namespace OrientacaoObj.Models;

public class Professor : Pessoa
{
    public Professor(string nome, string sobrenome) : base(nome, sobrenome)
    {
        
    }
    public double Salario { get; set; }
    public override void Apresentar()
    {
        Console.WriteLine($"Sou o professor: {NomeCompleto} e ganho: {Salario}");
    }
}
