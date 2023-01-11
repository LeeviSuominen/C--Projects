using System;

//Lohikäärmeen terveyspiseet
int lohikaarme = 10;
//Kaupungin terveyspisteet
int kaupunki = 15;
//lohikäärmeen etäisyys
int etaisyys = 0;
//Vahinko muuttuja joka muuttuu kierrosten jaollisuuden mukaan
int vahinko = 0;
//kierrosmäärä
int kierros = 1;
//Ammuksen etäisyys muuttuja
int ammus = 101;
//Määrittää osuiko pelaajan ampuma ammus lohikäärmeeseen
bool osu = false;
//Määrittää onko peli loppu vai käynnissä
bool loppu = false;
// tämä muuttuja kertoo haluaako pelaaja pelata yksin vai kaksin peliä
int vastaus = 0;



// kysyy pelaajalta pelataanko yksin vai kaksinpeliä
void pelaajamaara()
{

    while (vastaus < 1 || vastaus > 2)
    {
        Console.WriteLine("Yksin peli (1) vai kaksin peli (2)?");
        vastaus = Convert.ToInt32(Console.ReadLine());
        if (vastaus == 1)
        {
            yksinpelaaminen();
        }

        else if (vastaus == 2)
        {
            kaksinpelaaminen();
        }
    }

}


//Käskee koodin pyörittää "pelinkulku" metodia eli kirjaimellisesti pelin kulkua niin kauan kunnes peli loppuu
pelinkulku();
if (loppu)
{
    lopetus();
}
//Tämä metodi kysyy pelaajalta haluaako hän pelata yksin vai kaksin peliä
void pelinkulku()
{    
        pelaajamaara();
}
// Tämä metodi arpoo numeron 0-100 väliltä yksinpeliä varten
void yksinpeli()
{
    Random arvontakone = new Random();
    etaisyys = arvontakone.Next(1, 101);
}

//tämä metodi sisältää koodit yksinpeliä varten
void yksinpelaaminen()
{
    //Peli pyörii kunnes jomman kumman teveyspisteet ovat 0
    while (kaupunki > 0 && lohikaarme > 0)
    {
        if (kierros == 1){
            yksinpeli(); 
        }
        alustava();
        vahinkopisteet();
        //Vaihtaa tekstin väriä
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Kanuuna tekee {vahinko} pistettä vahinkoa tällä kierroksella");
        Console.ForegroundColor = ConsoleColor.White;
        ampuminen();
        osuma();
        tarkeatmuuttujat();
    }
    loppu = true;


}

// tämä metodi sisältää koodit kaksinpeliä varten
void kaksinpelaaminen()
{
    //Peli pyörii kunnes jomman kumman teveyspisteet ovat 0
    while (kaupunki > 0 && lohikaarme > 0)
    {
        kaksinpeli();
        alustava();
        vahinkopisteet();
        //Vaihtaa tekstin väriä
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Kanuuna tekee {vahinko} pistettä vahinkoa tällä kierroksella");
        Console.ForegroundColor = ConsoleColor.White;
        ampuminen();
        osuma();
        tarkeatmuuttujat();
    }
    loppu = true;


}



//Tämä metodi printtaa kaikki tarvittavat tiedot ennen peliä ja ennen jokaista kierrosta
void alustava()
{
    if (kierros == 1)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Pelaajan 2 vuoro");
        Console.ForegroundColor = ConsoleColor.White;
    }
    Console.WriteLine($"TILANNE: Kierros: {kierros}  Lohikäärmeen terveyspisteet: {lohikaarme}  Kaupungin terveyspisteet: {kaupunki}");

}

//Määritetään lohikäärmeen etäisyys kaksinpelissä
void kaksinpeli()
{
    while (etaisyys > 100 || etaisyys < 1)
    {
        Console.WriteLine("Pelaaja 1, kuinka kaukana lohikäärme on kaupungista?");
        etaisyys = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
    }
    return;
}

//Kysytään käyttäjältä mille etäisyydelle kanuunalla ammutaan
void ampuminen()
{
    Console.WriteLine("Mille etäisyydelle kanuunalla ammutaan?");
    Console.ForegroundColor = ConsoleColor.Cyan;
    ammus = Convert.ToInt32(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.White;
}

// määritetään ammuksien vahinkopisteet kierrosten jaollisuuden mukaan
void vahinkopisteet()
{
    //määritetään ammuksen vahinko kun kierros on jaollinen kolmella ja viidellä
    if (kierros % 3 == 0 && kierros % 5 == 0)
    {
        vahinko = 10;
    }
    // määritetään ammuksen vahinko kun kierros on jaollinen kolmella tai viidellä
    else if (kierros % 3 == 0 || kierros % 5 == 0)
    {
        vahinko = 3;
    }
    // määritetään ammuksen vahinko jos kierros ei ole jaollinen kolmella ja/tai viidellä
    else
    {
        vahinko = 1;
    }
}

//Kerrotaan osuiko lohikäärmeeseen pelaajan ampuma ammus
void osuma()
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    if (ammus > etaisyys)
    {
        Console.WriteLine("Ammus meni yli.");
    }
    else if (ammus < etaisyys)
    {
        Console.WriteLine("Ammus meni ali.");
    }
    else
    {
        Console.WriteLine("Osuma!");
        osu = true;
    }
    Console.ForegroundColor = ConsoleColor.White;
}

//Kierroksen lopussa tekee tarpeelliset muutokset muuttujiin kuten lisää yhden kierroksen yms...
void tarkeatmuuttujat()
{
    Console.WriteLine(new string('-', 80));

    //Lisätään kierros
    kierros++;

    //Vähennetään lohikäärmeeltä teveyspiste/pisteet, jos siihen osuttiin
    if (osu)
    {
        lohikaarme = lohikaarme - vahinko;
    }
    //Vähentää yhden terveyspisteen kaupungilta
    kaupunki--;
    //Ammuksen etäisyyttä muutetaan, jotta se kysytään ensi kierroksellakin
    ammus = 101;
}

//Pelin lopetus metodi joka sanan mukaisesti lopettaa pelin, jonka jälkeen kertoo kumpi pelaaja voitti
void lopetus()
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    if (lohikaarme == 0 || lohikaarme <= 0)
    {
        Console.WriteLine("Pelaaja 2 voitti!");
    }
    else
    {
        Console.WriteLine("Pelaaja 1 voitti!");
    }
    Console.ForegroundColor = ConsoleColor.White;
}