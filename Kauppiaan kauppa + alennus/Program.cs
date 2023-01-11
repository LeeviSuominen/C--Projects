using System;

namespace Kauppiaankauppa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nimi;
            float hinta;
            Console.WriteLine("KAUPPA");
            Console.WriteLine("Inventaario:");
            Console.WriteLine("1 - Miekka");
            Console.WriteLine("2 - Kirves");
            Console.WriteLine("3 - Köysi");
            Console.WriteLine("4 - Kanootti");
            Console.WriteLine("5 - Lusikka & Haarukka");
            Console.WriteLine("6 - Makuupussi");
            Console.WriteLine("7 - Teltta");
            Console.WriteLine("Minkä esineen hintaa haluat tiedustella");
            string input;
            input = Console.ReadLine();

            string response;
            response = input switch

            {
                "1" => "Miekka maksaa ",
                "2" => "Kirves maksaa ",
                "3" => "Köysi maksaa ",
                "4" => "Kanootti maksaa ",
                "5" => "Lusikka & Haarukka maksaa ",
                "6" => "Makuupussi maksaa ",
                "7" => "Teltta maksaa ",
                => "Tätä ei ole myynnissä"

            };
            hinta = input switch
            {
                "1" => 100.0f,
                "2" => 80.0f,
                "3" => 20.0f,
                "4" => 120.0f,
                "5" => 15.0f,
                "6" => 30.0f,
                "7" => 25.0f
            };

            Console.WriteLine("Mikä on nimesi?");
            nimi = Console.ReadLine();
            if (nimi == "Leevi")
            {
                hinta = hinta / 2;
            }

            Console.WriteLine(response + hinta + " kultakolikkoa");
        }
    }
}