Console.WriteLine(@"Ahoj, jsem Dalibor Klíma, chodím na SŠ Educhem a mám rád/baví mě: ");

string[] zajmy = { "anime", "hry", "spánek", "filmy/seriály" };
foreach (var item in zajmy)
{
    Console.WriteLine("- " + item);
}
