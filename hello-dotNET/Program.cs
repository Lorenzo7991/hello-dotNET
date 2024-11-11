using System.Text.RegularExpressions;

try
{
    string name;

    while (true)
    {
        Console.Write("Inserisci il tuo nome: ");
        name = Console.ReadLine();

        if (Regex.IsMatch(name, @"^[a-zA-Z]+$"))
        {
            Console.WriteLine($"Ciao, {name}! Benvenuto in .NET!");
            break; 
        }
        else
        {
            Console.WriteLine("Nome non valido. Inserisci solo lettere.");
        }
    }
}
catch (FormatException)
{
    Console.WriteLine("Errore di formattazione.");
}
