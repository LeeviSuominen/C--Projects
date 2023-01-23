int ritari = 15;
int orkki = 15;
int vahinko = 0;

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Olet urhea ritari ja sinut on lähetetty kukistamaan kylää kiusaava örkki. Löydät örkin metsästä ja tämä hyökkää sinua kohti. Taistelu alkakoot!");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine(new string('-', 80));


while (ritari > 0 && orkki > 0) 
{
    Pelinkulku();
}

void Pelinkulku()
{
    Tilanne();
    Pelinloppu();
}
void Tilanne()
{
    Console.WriteLine($"TILANNE: Ritari (Sinä): {ritari}/15  Örkki: {orkki}/15 ");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("1 - Hyökkää \n2 - Puolusta");
    Console.ForegroundColor= ConsoleColor.White;
    Console.Write("Minkä valitset? ");
    string? valinta = Console.ReadLine();

    if (valinta == "1")
    {
        Hyokkays();
        OrkinHyokkays();
    }
    else if (valinta == "2")
    {
        Puolustus();
    }
    else
    {
        Console.WriteLine("Virheellinen valinta!");
        Pelinkulku();
    }
}

void Hyokkays()
{
    Vahinkopisteet();
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("Hyökkäät miekallasi!");
    Console.WriteLine($"Teit {vahinko} vahinkoa Örkkiin!");
    Console.ForegroundColor = ConsoleColor.White;
    orkki = orkki - vahinko;
}

void OrkinHyokkays()
{
    Vahinkopisteet();
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Örkki hyökkää sinua kohti nuijallaan!");
    Console.WriteLine($"Örkki teki sinuun {vahinko} vahinkoa.");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(new string('-', 80));
    ritari = ritari - vahinko;
}

void Puolustus()
{
    Vahinkopisteet();
    Console.ForegroundColor= ConsoleColor.DarkBlue;
    Console.WriteLine("Puolustaudut kilvelläsi!");
    Console.WriteLine($"Örkin nuija osuu kilpeesi, tehden sinuun vain {vahinko/2} vahinkoa.");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(new string('-', 80));
    ritari = ritari - (vahinko/ 2);
}

void Vahinkopisteet()
{
    Random random = new Random();
    vahinko = random.Next(1, 6);
}

void Pelinloppu()
{
    if (ritari == 0 || ritari <= 0)
    {
        Console.ForegroundColor= ConsoleColor.Red;
        Console.WriteLine("Örkki voitti sinut taistelussa!");
        Console.ForegroundColor = ConsoleColor.White;
    }

    else if (orkki == 0 || orkki <= 0) 
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Kukistit örkin taistelussa. Onneksi olkoon!");
        Console.ForegroundColor = ConsoleColor.White;
    }
}