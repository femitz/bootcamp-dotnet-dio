namespace OrientacaoObj.Models;

public class Aluno : Pessoa
{
    
    public Aluno(string nome, string sobrenome) : base (nome, sobrenome)
    {
        
    }

    public double Nota { get; set; }
    
    public override void Apresentar()
        {
            Console.WriteLine($"Meu nome é: {NomeCompleto} e sou um aluno nota {Nota}");
        }
}
