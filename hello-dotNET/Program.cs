using System.Text.RegularExpressions;

try
{
    Console.Write("Inserisci il tuo nome: ");
    string name = Console.ReadLine();

    if (Regex.IsMatch(name, @"^[a-zA-Z]+$"))
    {
        Console.WriteLine($"Ciao, {name}! Benvenuto in .NET!");
    }
    else
    {
        Console.WriteLine("Nome non valido. Inserisci solo lettere.");
    }
}
catch (FormatException)
{
    Console.WriteLine("Errore di formattazione.");
}
