﻿using System;

class Laboratorio92
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0 || i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
