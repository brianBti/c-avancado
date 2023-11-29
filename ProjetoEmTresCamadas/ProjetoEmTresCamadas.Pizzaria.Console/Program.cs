// See https://aka.ms/new-console-template for more information
using ProjetoEmTresCamadas.Pizzaria.RegraDeNegocio;

Console.WriteLine("Quer uma pizza ?");
Console.WriteLine("S para sim / N para não");
var resposta = Console.ReadLine();
Console.WriteLine(resposta);

if(resposta == "S")
{
    var pizza = new Pizza();
    Console.WriteLine("Qual o sabor de pizza: calabresa 'C' ou Frango 'Frangro' ? ");
    var sabor = Console.ReadLine();
    Console.WriteLine($"O sabor escolhido foi = {pizza.DefinirSabor(sabor)}");
    Console.WriteLine("Qual o tamanho da pizza, pequeno 'P' , medio 'M',grande 'G'? ");
    var tamanho = Console.ReadLine();
    Console.WriteLine($"O tamanho escolhido foi = {pizza.DefinirTamanho(tamanho)}");

    Console.WriteLine($"Sua pizza é {pizza.ToString()}");
}
Console.WriteLine("Fim");