// See https://aka.ms/new-console-template for more information

Console.WriteLine("Avaliar uma expressão");
#region Avaliar uma expressão
//Console.WriteLine("a" == "a");
//Console.WriteLine("a" == "A");
//Console.WriteLine(1 == 2);

//string myValue = "a";
//Console.WriteLine(myValue == "a");

//string value1 = " a";
//string value2 = "A ";
//Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());


//Console.WriteLine("\nExercicio de expressões boolianas");
//string permission = "Admin|Manager";
//int level = 53;

//if (permission.Contains("Admin"))
//{
//    if (level > 55)
//    {
//        Console.WriteLine("Welcome, Super Admin user.");
//    }
//    else
//    {
//        Console.WriteLine("Welcome, Admin user.");
//    }
//}
//else if (permission.Contains("Manager"))
//{
//    if (level >= 20)
//    {
//        Console.WriteLine("Contact an Admin for access.");
//    }
//    else
//    {
//        Console.WriteLine("You do not have sufficient privileges.");
//    }
//}
//else
//{
//    Console.WriteLine("You do not have sufficient privileges.");
//}
#endregion

Console.WriteLine("Escopo da variavel");
#region  Controlar o escopo da variável e a lógica

//bool flag = true;
//if (flag)
//{
//    int value = 10;
//    Console.WriteLine($"Inside of code block: {value}");
//}

#endregion

//Console.WriteLine("Ramificar o fluxo de código");

//string[] names = { "Alex", "Eddie", "David", "Michael" };
//for (int i = 0; i < names.Length; i++)
//    if (names[i] == "David") names[i] = "Sammy";

//foreach (var name in names) Console.WriteLine(name);


//string? readResult;
//Console.WriteLine("Enter a string: ");

//do
//{
//    readResult = Console.ReadLine();
//} 
//while (readResult == "");


// entre 5 e 10

//int numberTeste = 0;

//while ( numberTeste < 5 || numberTeste > 10)
//{
//    Console.WriteLine("Digite um valor entre 5 e 10, por favor");
//    numberTeste = int.Parse(Console.ReadLine());
//}

//Console.WriteLine("Do-While");
//do
//{
//    Console.WriteLine("Digite um valor entre 5 e 10, por favor");
//    numberTeste = int.Parse(Console.ReadLine());
//} while (numberTeste < 5 || numberTeste > 10);


// // Projeto 2 : solicitar ao usuário um dos três nomes de função: Administrador, Gerente ou Usuário.


// string entradaUsuario = Console.ReadLine();    

string[] ops = { "Administrator", "Manager", "User", "Oi" };


while (true)
{
    Console.WriteLine($"Digite Administrator, Manager ou User");
    string entradaUsuario = Console.ReadLine();
    string valorDigitado = entradaUsuario.Trim().ToLower();
    if (valorDigitado == "administrator" || valorDigitado  == "manager" || valorDigitado == "user")
    {
        Console.WriteLine($"Você selecionou {entradaUsuario}");
        break;
    }
    else
    {
        Console.WriteLine("Digitou uma opção inválida");
    }

}




