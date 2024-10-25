namespace OrientacaoObj.Models.Escola;

public class Diretor : Professor
{
    public Diretor(string nome, string sobrenome) : base(nome, sobrenome)
    {
    }

    public override void Apresentar()
    {
        Console.WriteLine($"Sou o diretor: {NomeCompleto} e ganho: {Salario}");
    }
}
