//using System.Text.RegularExpressions;

/*try
{
    string name;

    // Ciclo per continuare a chiedere il nome finché non viene inserito correttamente
    while (true)
    {
        Console.Write("Inserisci il tuo nome: ");
        // Uso  dell'operatore ?? per gestire il valore null, assegnando una stringa vuota se l'input è null
        name = Console.ReadLine() ?? "";
        // Condizione per verificare che l'input non sia vuoto e che soddisfi la regex
        if (!string.IsNullOrEmpty(name) && Regex.IsMatch(name, @"^[a-zA-Z]+$"))
        {
            // Se il nome è valido, stampare il messaggio di benvenuto e terminare il ciclo
            Console.WriteLine($"Ciao, {name}! Benvenuto in .NET!");
            break; 
        }
        else
        {
            // Se il nome non è valido, messaggio d'errore
            Console.WriteLine("Nome non valido. Inserisci solo lettere e non lasciare il campo vuoto.");
        }
    }
}
catch (FormatException)
{
    // Gestione eventuali eccezioni di formattazione
    Console.WriteLine("Errore di formattazione.");
}*/

using hello_dotNET;

IDriveable myCar = new Car();
IDriveable myBike = new Bike();

IDriveable myBoat = new Boat();


myCar.Drive();
myBike.Drive();
myBoat.Drive();