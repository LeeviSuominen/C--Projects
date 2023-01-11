using System;

Console.WriteLine("Kuinka monta kalaa karhut ovat kalastaneet?"); 
int määrä = Convert.ToInt32(Console.ReadLine());
int karhuille = määrä / 4;
int kissalle = määrä - (karhuille*4);
Console.WriteLine("Jokainen karhu saa " + karhuille + " kalaa. " + "Kissa saa " + kissalle + " kalaa.");



