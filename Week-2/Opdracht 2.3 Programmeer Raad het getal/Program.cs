Console.WriteLine("Welkom bij Raad Het Getal!");

var randomNumberGenerator = new Random();
var secretNumber = randomNumberGenerator.Next(1, 101);

var isPlaying = true;

while (isPlaying)
{
    Console.Write("Voer een getal in tussen de 1 en 100: ");

    var inputRaw = Console.ReadLine();

    int inputParsed;
    try
    {
        inputParsed = int.Parse(inputRaw);
    }
    catch (FormatException)
    {
        Console.WriteLine("Ongeldige invoer, probeer opnieuw.");
        continue;
    }

    if (secretNumber > inputParsed)
    {
        Console.WriteLine("Hoger.");
    }
    else if (secretNumber < inputParsed)
    {
        Console.WriteLine("Lager.");
    }
    else
    {
        Console.WriteLine("Hebbes!");
        isPlaying = false;
    }
}

Console.WriteLine("Einde.");