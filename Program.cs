using System.IO.Compression;
using Cauculadora;
repetir:
Console.WriteLine("Digite o Primeiro Numero");
if(!decimal.TryParse(Console.ReadLine(), out decimal valor1))
{
  Console.WriteLine("Valor invalido!");
  goto repetir;
  }
Console.WriteLine("Digite o Segundo Numero");
if(!decimal.TryParse(Console.ReadLine(), out decimal valor2))
{
  Console.WriteLine("Valor invalido!");
  goto repetir;
  }
Operacoes.RealizarAdicao(valor1,valor2);

