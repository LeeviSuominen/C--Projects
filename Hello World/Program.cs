﻿using System;
 static int RandomNumber(int min, int max)
{
    Random random = new Random();
    return random.Next(min, max);
}