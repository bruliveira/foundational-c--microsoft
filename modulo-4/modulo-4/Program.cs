// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography;

Console.WriteLine("Módulo 4");

Console.WriteLine("\n-> Converter tipos de dados");
#region "Metodo TryParse"
string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Após convertido: {result}");
}
else
{
    Console.WriteLine("Falha na conversão");
}
#endregion

#region "Imprimir operações matemáticas como tipos de números específicos"
//int valor1 = 12;
//decimal valor2 = 6.2m;
//float valor3 = 4.3f;

//int result1 = Convert.ToInt32((decimal)valor1 / valor2);
//decimal result2 = valor2 / (decimal)valor3;
//float result3 = valor3 / valor1;

//Console.WriteLine($"Dividindo o valor1 pelo valor2, o resultado será: {result1}");
//Console.WriteLine($"Dividindo o valor2 pelo valor3, o resultado será: {result2}");
//Console.WriteLine($"Dividindo o valor3 pelo valor1, o resultado será: {result3}");
#endregion


Console.WriteLine("\n-> Executar operações em matrizes usando métodos auxiliares em C#");

#region "Métodos Sort, Reverse, Clear, Resize"
string[] paletas = {"vermelho", "branco", "preto", "azul" };

Console.WriteLine("\nInvertendo...");
Array.Reverse(paletas); // Invertendo a ordem
foreach (var palet in paletas)
{
    Console.WriteLine($"-> {palet}");
}

Console.WriteLine("\nSorteando...");
Array.Sort(paletas); // Classificar os itens: alfanumérico
foreach (var palet in paletas)
{
    Console.WriteLine($"-> {palet}");
}

Console.WriteLine($"\nAntes de remover: {paletas[0]}");
Console.WriteLine("Removendo...");
Array.Clear(paletas,0,2); // Limpa começando do elemento 0 até o 2
foreach (var palet in paletas)
{
    Console.WriteLine($"-> {palet}");
}
if (paletas[0] != null)
{
    Console.WriteLine($"Depois de remover: {paletas[0].ToLower()}");
}

Console.WriteLine($"\nRedimensionando...");
Array.Resize(ref paletas,6);
paletas[4] = "verde";
paletas[5] = "rosa";
foreach (var palet in paletas)
{
    Console.WriteLine($"-> {palet}");
}

Console.WriteLine($"\nRemovendo elementos...");
Array.Resize(ref paletas, 3);

foreach (var palet in paletas)
{
    Console.WriteLine($"-> {palet}");
}
#endregion

#region "Split, Join"
Console.WriteLine("\n");
string valor = "abc123";

char[] valoresArray = valor.ToCharArray(); //Tranforma em várias posições
Array.Reverse(valoresArray); // Reverte a ordem
string resultado = new string(valoresArray);
Console.WriteLine(resultado);

Console.WriteLine("Utilizando Join...");
string resultJoin = String.Join(",", valoresArray);
Console.WriteLine(resultJoin);

Console.WriteLine("\nSplit");
string[] items = resultJoin.Split(",");
foreach (string item in items)
{
    Console.WriteLine(item);
}
#endregion




