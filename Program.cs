// See https://aka.ms/new-console-template for more information
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // SnakeGame game = new SnakeGame();
        // game.Run();
        Animal cat = new Cat("20kg", "1.5", "kitty");
        cat.PrintInfo();
        System.Console.WriteLine();
        cat = new Kitten("10kg", "1", "kitty", 2);
        cat.PrintInfo();
    }
}