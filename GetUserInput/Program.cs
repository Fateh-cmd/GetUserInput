using System;

class Program
{
    static string GetUserInput()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        Console.Write($"Hello, {name}! Please enter some text: ");
        string text = Console.ReadLine();

        return text;
    }

    static void Main()
    {
        string enteredText = GetUserInput();
        Console.WriteLine($"You entered the following text: {enteredText}");
    }
}

