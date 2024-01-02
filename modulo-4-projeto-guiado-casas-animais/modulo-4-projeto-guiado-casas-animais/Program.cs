// See https://aka.ms/new-console-template for more information
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("-> Novas casas para cães e gatos mecessitados");
// O array ourAnimals irá armazenar o seguinte
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";
string suggestedDonation = "";

// Variáveis ​​que suportam entrada de dados
int maxPets = 8;
string? readResult;
string menuSelection = "";

// Matriz usada para armazenar dados de tempo de execução, não há dados persistentes
string[,] ourAnimals = new string[maxPets, 7];

// Criar dados de amostra entradas da matriz ourAnimals
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            suggestedDonation = "85.00";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "gus";
            suggestedDonation = "49.99";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "snow";
            suggestedDonation = "40.00";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "lion";
            suggestedDonation = "45.00";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }
    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
    ourAnimals[i, 6] = "Suggested Donation: " + suggestedDonation;
}
string op = "";
do
{
    Console.WriteLine("\n1 - Listar todas as informações atuais sobre animais de estimação\n2 - Exibir todos os cães com uma característica específica\nEntre na seleção do item de menu ou digite 'Sair' para sair do programa");
     op = Console.ReadLine();

    if (op != "1" && op != "2" && op.ToLower() != "sair")
    {
        Console.WriteLine("\nTente opção válida");
    }
    else if (op == "1")
    {
        Console.WriteLine("\nInformações atuais sobre animais de estimação");
        for (int i = 0; i < maxPets; i++)
        {
            if (ourAnimals[i, 0] != "ID #: ")
            {
                Console.WriteLine();
                for (int j = 0; j < 7; j++)
                {
                    Console.WriteLine(ourAnimals[i, j]);
                }
            }
        }
    }
    else if(op == "2")
    {
        string dogCharacteristic = "";
        string dogDescription = "";
        
        while (dogCharacteristic == "")
        {
            // Usuário insire características físicas para pesquisar
            Console.WriteLine($"\nEnter one desired dog characteristics to search for");
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                dogCharacteristic = readResult.ToLower().Trim();
            }
        }
        bool noMatchesDog = true;
        for (int i = 0; i < maxPets; i++)
        {
            if (ourAnimals[i, 1].Contains("dog"))
            {
                // Pesquise descrições combinadas e resultados de relatórios
                dogDescription = ourAnimals[i, 4] + "\n" + ourAnimals[i, 5];
                if (dogDescription.Contains(dogCharacteristic))
                {
                    Console.WriteLine($"\nOur dog {ourAnimals[i, 3]} is a match!");
                    Console.WriteLine(dogDescription);
                    noMatchesDog = false;
                }
            }
        }
        if (noMatchesDog)
        {
            Console.WriteLine("None of our dogs are a match found for: " + dogCharacteristic);
        }
    }
    else
    {
        break;
    }
} while (op.ToLower() != "sair");