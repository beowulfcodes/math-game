using MathGame;

var menu = new Menu();

Console.WriteLine("This is a Math game, derived from the C# Academy console application projects.");
Console.Write("What is your name? ");
string? name = Console.ReadLine();

if(string.IsNullOrEmpty(name))
{
    Console.WriteLine("Name should not be empty!");
    name = Console.ReadLine();
}

menu.ShowMenu(name);

