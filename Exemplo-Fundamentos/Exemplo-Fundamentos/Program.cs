using Exemplo_Fundamentos.Common.Models;

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, Felipe.");

Pessoa p = new Pessoa();
p.Nome = "Felipe";
p.Idade = 21;

// ou

Pessoa p2 = new Pessoa
{
    Nome = "Gabriel",
    Idade = 22
};

p.Apresentar();
p2.Apresentar();


DateTime dt = DateTime.Now;
Console.WriteLine(dt.ToString("dd/MM/yyyy HH:mm"));

Calculadora calc = new Calculadora();

calc.Somar(10, 20);
calc.Subtrair(10, 20);
calc.Divisao(25, 5);
calc.Multiplicacao(5, 5);
calc.Potencia(3, 3);

int[] arrayInteiros = new int[3];
arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;

int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

for (int i = 0; i < arrayInteiros.Length; i++)
{
    Console.WriteLine($"Posição número: {i} - {arrayInteiros[i]}");
}


List<string> listaString = new List<string>();
listaString.Add("São Paulo");
listaString.Add("Rio de Janeiro");
listaString.Add("Belo Horizonte");

foreach(string item in listaString)
{
    Console.WriteLine(item);
}
// int maiorIdade = 18;
// bool possuiAutorizacao = false;

// Console.WriteLine("Digite sua idade:");
// int idadeLida = int.Parse(Console.ReadLine());

// Console.WriteLine("Possui autorização?(y/n):");
// string autorizacaoLida = Console.ReadLine();

// bool matchAutorizacao = autorizacaoLida == "y"; 
// bool matchIdade = idadeLida >= maiorIdade;

// if(matchIdade && matchAutorizacao) 
// {
//     Console.WriteLine("Entrada Liberada");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada.");
// }

// Console.WriteLine("Digite uma letra:");

// string letra = Console.ReadLine();

// switch(letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;
//     default:
//         Console.WriteLine("Não é uma vogal.");
//         break;
// }
