﻿// See https://aka.ms/new-console-template for more information
using Calculator;
double result = 0;
metoder m = new metoder();
Console.WriteLine("Skriv det første tal:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Skriv det andet tal:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vælg en operation: +, -, *, /");
string? operation = Console.ReadLine();

switch (operation)
    {
        case "+":
            result = m.add(a, b);
            break;
        case "-":
            result = m.subtract(a, b);
            break;
        case "*":
            result = m.multiplayer(a, b);
            break;
        case "/":
            result = m.division(a, b);
            break;
        default:
            throw new Exception("Ugyldig operation");
    }

Console.WriteLine($"Resultatet er: {result}");

