// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;
using System.Security.Cryptography;

Console.WriteLine("\t\t-> Módulo 4");

Console.WriteLine("\nParte 2: Converter tipos de dados");
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

Console.WriteLine("\nParte 3: Executar operações em matrizes usando métodos auxiliares em C#");
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

#region "Inverter as palavras de uma frase"
Console.WriteLine("\n-> Desafio de inverter palavras em uma frase");

string palavraFrase = "Oi amigos lindos";
string[] palavrasSeparadas = palavraFrase.Split(" "); // Separando cada palavra pelo espaço
Console.WriteLine($"Quantidade de palavras na frase: {palavrasSeparadas.Length}");

string[] novaPalavra = new string[palavrasSeparadas.Length];

for (int i = 0; i < palavrasSeparadas.Length; i++)
{
    char[] letras = palavrasSeparadas[i].ToCharArray();
    Array.Reverse(letras);
    novaPalavra[i] = new string(letras);
}
string resultadoPalavra = string.Join(" ", novaPalavra);
Console.WriteLine($"Resultado final da frase: {resultadoPalavra}");
#endregion

#region "Analise de cadeia de caractere de pedidos"
Console.WriteLine("\n-> Analise de cadeia de caracteres de pedidos");
string pedidos = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] pedidoCada = pedidos.Split(",");
Array.Sort(pedidoCada);
for (int i = 0; i < pedidoCada.Length; i++)
{
    if (pedidoCada[i].Length != 4)
    {
        Console.WriteLine($"{pedidoCada[i]} - Error!");
    }
    else
    {
        Console.WriteLine($"{pedidoCada[i]}");
    }
}

#endregion

Console.WriteLine("\nParte 4: Formatar dados alfanuméricos");
#region "Formatação composta"
string dado1 = "Hello";
string dado2 = "World";
string resultadoComposta = string.Format("{0} {1}!", dado1, dado2);
Console.WriteLine(resultadoComposta);
#endregion

Console.WriteLine("\nParte 5: Modificar o conteúdo de cadeias de caracteres usando métodos internos");
#region "Modificar usando metódos auxiliares"
string message = "(What if) there are (more than) one (set of parentheses)?";

////int openingPosition = message.IndexOf('(');
////int closingPosition = message.IndexOf(')');

//// LastIndexOf pega a última ocorrência do caractere
//int openingPosition = message.LastIndexOf('(');
//openingPosition += 1;
//int closingPosition = message.LastIndexOf(')');

//Console.WriteLine(openingPosition);
//Console.WriteLine(closingPosition);

//int length = closingPosition - openingPosition;
//Console.WriteLine(message.Substring(openingPosition, length));

while (true)
{
    int openingPosition = message.IndexOf('(');
    if (openingPosition == -1) break;

    openingPosition += 1;
    int closingPosition = message.IndexOf(')');
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    // Note the overload of the Substring to return only the remaining 
    // unprocessed message:
    message = message.Substring(closingPosition + 1);
}


string message1 = "Help (find) the {opening symbols}";
Console.WriteLine($"\nSearching THIS Message: {message1}");
char[] openSymbols1 = { '[', '{', '(' };
int startPosition1 = 6;
int openingPosition1 = message1.IndexOfAny(openSymbols1);
Console.WriteLine($"Found WITHOUT using startPosition: {message1.Substring(openingPosition1)}");

openingPosition1 = message1.IndexOfAny(openSymbols1, startPosition1);
Console.WriteLine($"Found WITH using startPosition {startPosition1}: {message1.Substring(openingPosition1)}");


#endregion

#region "Usar os métodos Remove() e Replace() e Remover de cadeia de caractere" 
Console.WriteLine("\n");
string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);

string message2 = "This--is--ex-amp-le--da-ta";
message2 = message2.Replace("--", " ");
message2 = message2.Replace("-", "");
Console.WriteLine(message2);



Console.WriteLine("cadeia de caracteres de entrada");
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

// Extract the "quantity"
const string openSpan = "<span>";
const string closeSpan = "</span>";

int quantityStart = input.IndexOf(openSpan) + openSpan.Length; // + length of <span> so index at end of <span> tag
int quantityEnd = input.IndexOf(closeSpan);
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength);
quantity = $"Quantity: {quantity}";

// Set output to input, replacing the trademark symbol with the registered trademark symbol
const string tradeSymbol = "&trade;";
const string regSymbol = "&reg;";
output = input.Replace(tradeSymbol, regSymbol);

// Remove the opening <div> tag
const string openDiv = "<div>";
int divStart = output.IndexOf(openDiv);
output = output.Remove(divStart, openDiv.Length);

// Remove the closing </div> tag and add "Output:" to the beginning
const string closeDiv = "</div>";
int divCloseStart = output.IndexOf(closeDiv);
output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

Console.WriteLine(quantity);
Console.WriteLine(output);

#endregion

Console.WriteLine("\nParte 6: Projeto guiado – Trabalhar com os dados variáveis em C#");
#region


#endregion

