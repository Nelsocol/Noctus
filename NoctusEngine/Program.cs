﻿using System;

namespace NoctusEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(args[0]);
            game.Run();
        }
    }
}
