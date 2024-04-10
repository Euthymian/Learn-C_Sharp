// See https://aka.ms/new-console-template for more information
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.SetCursorPosition(0,0); // đặt vị trí của rắn hoặc mồi tại tọa độ (x, y)
        Console.ForegroundColor = ConsoleColor.Green; // đặt màu cho rắn
        Console.BackgroundColor = ConsoleColor.Red; // đặt màu cho mồi
        Console.Write("O"); // vẽ rắn hoặc mồi bằng ký tự O
        Console.BackgroundColor = ConsoleColor.Black;
    }
}