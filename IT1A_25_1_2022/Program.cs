Console.WriteLine("Zadejte email: ");
string email = Console.ReadLine();
if(email.Contains("@"))
{
    email = email.Trim();
    if(email.EndsWith(".cz"))
    {
        Console.WriteLine("Váš email je dlouhý " + email.Length + " znaků");
    }
    else if(email.EndsWith(".sk"))
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.WriteLine("Váš email je dlhý " + email.Length + " znaků");
    }
    else if(email.EndsWith(".com"))
    {
        Console.WriteLine("Your email address is " + email.Length + " characters long");
    }
}
else
{
    Console.WriteLine("Chybně zadaný email :(");
}
