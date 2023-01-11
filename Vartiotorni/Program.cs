using System;

Console.WriteLine("Anna X arvo");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Anna Y arvo");
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 && y == 0)
{
    Console.WriteLine("The enemy is in the middle!");
} 

else if (x < 0 && y < 0)
{
    Console.WriteLine("The enemy is to the south west!");
}

else if (x > 0 && y > 0)
{
    Console.WriteLine("The enemy is to the north east!");
}

else if (x > 0 && y == 0)
{
    Console.WriteLine("The enemy is to the east!");
}

else if (x > 0 && y < 0)
{
    Console.WriteLine("The enemy is to the south east!");
}

else if (x == 0 && y > 0)
{
    Console.WriteLine("The enemy is to the north!");
}

else if (x == 0 && y < 0)
{
    Console.WriteLine("The enemy is to the south!");
}

else if (x < 0 && y > 0)
{
    Console.WriteLine("The enemy is to the north west!");
}

else if (x < 0 && y == 0)
{
    Console.WriteLine("The enemy is to the west!");
}