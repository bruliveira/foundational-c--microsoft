// See https://aka.ms/new-console-template for more information

Console.WriteLine("-> Matrizes");

#region Exemplo 1 de construção de matriz
//string[] fraudulentOrderIDs = new string[3];

//fraudulentOrderIDs[0] = "A123";
//fraudulentOrderIDs[1] = "B456";
//fraudulentOrderIDs[2] = "C789";
//fraudulentOrderIDs[3] = "D000";

//Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
//Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
//Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

#endregion

#region Loop em matriz
//Console.WriteLine("\nVamos ver uns nomes legais");

//string[] names = { "Rowena", "Robin", "Bao" };
//int[] numeros = { 1, 2, 3 };
//int sum = 0;


//Console.WriteLine("\nForeach de strings");
//foreach (string name in names)
//{
//    Console.WriteLine(name);
//}

//Console.WriteLine("\nForeach de números");
//foreach (int item in numeros)
//{
//    Console.WriteLine(item);
//    sum += item;
//}
//Console.WriteLine("A soma foi: " + sum);


#endregion

#region Exercicio de iteração
Console.WriteLine("\nExercicio - verificar se os nomes começam com a letra B");
string name1 = "pob";

if (name1.StartsWith("B"))
{
    Console.WriteLine("The name starts with 'B'!");
}


string[] nomes = { "Maria", "Bruna", "Bia" };
foreach (string nome in nomes)
{
    if (nome.StartsWith("B"))
    {
        Console.WriteLine(nome);
    }
}

#endregion


Console.WriteLine("\n-> Código Legível");
#region Código legível


//Random dice = new Random();
//int roll1 = dice.Next(1, 7);
//int roll2 = dice.Next(1, 7);
//int roll3 = dice.Next(1, 7);
//int total = roll1 + roll2 + roll3;
//Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
//if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
//{
//    if ((roll1 == roll2) && (roll2 == roll3))
//    {
//        Console.WriteLine("You rolled triples!  +6 bonus to total!");
//        total += 6;
//    }
//    else
//    {
//        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//        total += 2;
//    }
//}

//string str = "The quick brown fox jumps over the lazy dog.";


//char[] charMessage = str.ToCharArray();
//Array.Reverse(charMessage);

//int x = 0;

//foreach (char i in charMessage) 
//{ 
//    if (i == 'o') 
//    { 
//        x++; 
//    } 
//}

//string new_message = new String(charMessage);

//Console.WriteLine(new_message);
//Console.WriteLine($"'o' appears {x} times.");

#endregion
