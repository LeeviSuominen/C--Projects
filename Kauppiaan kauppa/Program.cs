using System;

string input;

int hinta = 50;

Console.WriteLine("***Kauppa***");
Console.WriteLine("Inventaario:");
Console.WriteLine("1 - Miekka");
Console.WriteLine("2 - Kirves");
Console.WriteLine("3 - Köysi");
Console.WriteLine("4 - Kanootti");
Console.WriteLine("5 - Lusikka & Haarukka");
Console.WriteLine("6 - Makuupussi");
Console.WriteLine("7 - Teltta");
Console.WriteLine("Minkä esineen hintaa haluat tiedustella?");

input = Console.ReadLine();

switch(input)
{
    case "1":
        Console.WriteLine($"Miekka maksaa {hinta} kultakolikkoa.");
        break;

    case "2":
        Console.WriteLine("Kirves maksaa 60 kultakolikkoa.");
        break;

    case "3":
        Console.WriteLine("Köysi maksaa 15 kultakolikkoa.");
        break;

    case "4":
        Console.WriteLine("Kanootti maksaa 30 kultakolikkoa.");
        break;

    case "5":
        Console.WriteLine("Lusikka & Haarukka maksaa 10 kultakolikkoa.");
        break;

    case "6":
        Console.WriteLine("Makuupussi maksaa 20 kultakolikkoa.");
        break;

    case "7":
        Console.WriteLine("Teltta maksaa 35 kultakolikkoa.");
        break;

    default:
        Console.WriteLine("Pahoittelut. En tunnista tuotetta.");
            break;






}







