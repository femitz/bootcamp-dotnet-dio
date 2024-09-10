using System.Globalization;
using OrientacaoObj.Models;

using Newtonsoft.Json;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// 
// Serialize
// 
List<Venda> listaVenda = new List<Venda>();
Venda v1 = new Venda(1, "iPhone 15", 4797.00M, DateTime.Now);
Venda v2 = new Venda(2, "iPhone 14", 3897.00M, DateTime.Now);

listaVenda.Add(v1);
listaVenda.Add(v2);

string serializado = JsonConvert.SerializeObject(listaVenda, Formatting.Indented); // Converte o objeto para JSON

File.WriteAllText("Arquivos/vendas.json", serializado);

//
// Deserialize
// 
string conteudoJson = File.ReadAllText("Arquivos/vendas.json");
List<Venda> listaVendaDeserialize = JsonConvert.DeserializeObject<List<Venda>>(conteudoJson);

foreach (Venda venda in listaVendaDeserialize) 
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.Data}");
}
// string path = "Arquivos/leitura.txt";
// LeituraArquivo leituraArquivo = new LeituraArquivo();
// var(sucesso, linhas, qntdLinhas) = leituraArquivo.LerArquivo(path);

// Console.WriteLine($"O arquivo foi lido com sucesso? {sucesso}");

// foreach (string linha in linhas)
// {
//     Console.WriteLine(linha);
// }

// Console.WriteLine($"Quantidade de linhas: {qntdLinhas}");

// decimal valorMonetario = 1582.30M;
// int numero = 123456;

// Console.WriteLine(valorMonetario.ToString("C2"));
// Console.WriteLine(numero.ToString("##-##-##"));
// Console.WriteLine(dt);

// string dataString = "2024-01-02 18:00";
// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

// if (sucesso)
// {
//     Console.WriteLine(data);
// }