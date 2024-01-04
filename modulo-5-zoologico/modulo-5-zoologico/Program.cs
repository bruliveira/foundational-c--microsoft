// See https://aka.ms/new-console-template for more information
using System;
Random random = new Random();

Console.WriteLine("\n-> Projeto guiado: Zooológico");

string[] especiesZoologico =
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

string[,] group = GrupoAnimais();
RandomizarAnimais();
PlanSchoolVisit("\nEscola A");
PlanSchoolVisit("\nEscola B", 3);
PlanSchoolVisit("\nEscola C", 2);

void PlanSchoolVisit(string schoolName, int groups = 6)
{
    RandomizarAnimais();
    string[,] group = GrupoAnimais();
    Console.WriteLine(schoolName);
    ImprimirGrupo(group);
}
void RandomizarAnimais()
{
    for (int i = 0; i < especiesZoologico.Length; i++)
    {
        int r = random.Next(i, especiesZoologico.Length);

        string temp = especiesZoologico[i];
        especiesZoologico[i] = especiesZoologico[r];
        especiesZoologico[r] = temp;
    }
}

string[,] GrupoAnimais(int groups = 6)
{
    int start = 0;
    string[,] result = new string[groups, especiesZoologico.Length / groups];
    for (int i = 0; i < groups; i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = especiesZoologico[start++];
        }
    }
    return result;
}

void ImprimirGrupo(string[,] group)
{
    for (int i = 0; i < group.GetLength(0); i++)
    {
        Console.Write($"Group {i + 1}: ");
        for (int j = 0; j < group.GetLength(1); j++)
        {
            Console.Write($"{group[i, j]}  ");
        }
        Console.WriteLine();
    }
}