// See https://aka.ms/new-console-template for more information


using System.Drawing;

void draw(string[] arr1, string[] arr2, string[] arr3)
{
    color(arr1[0]);
    Console.Write("   |");
    color(arr1[1]);
    Console.Write("   |");
    color(arr1[2]);
    Console.Write("   ");
    Console.WriteLine();
    color(arr1[0]);
    Console.Write(" {0} |", arr1[0]);
    color(arr1[1]);
    Console.Write(" {0} |", arr1[1]);
    color(arr1[2]);
    Console.Write(" {0} ", arr1[2]);
    Console.WriteLine();
    color(arr1[0]);
    Console.Write("___|");
    color(arr1[1]);
    Console.Write("___|");
    color(arr1[2]);
    Console.Write("___");
    Console.WriteLine();
    color(arr2[0]);
    Console.Write("   |");
    color(arr2[1]);
    Console.Write("   |");
    color(arr2[2]);
    Console.Write("   ");
    Console.WriteLine();
    color(arr2[0]);
    Console.Write(" {0} |", arr2[0]);
    color(arr2[1]);
    Console.Write(" {0} |", arr2[1]);
    color(arr2[2]);
    Console.Write(" {0} ", arr2[2]);
    Console.WriteLine();
    color(arr2[0]);
    Console.Write("___|");
    color(arr2[1]);
    Console.Write("___|");
    color(arr2[2]);
    Console.Write("___");
    Console.WriteLine();
    color(arr3[0]);
    Console.Write("   |");
    color(arr3[1]);
    Console.Write("   |");
    color(arr3[2]);
    Console.Write("   ");
    Console.WriteLine();
    color(arr3[0]);
    Console.Write(" {0} |", arr3[0]);
    color(arr3[1]);
    Console.Write(" {0} |", arr3[1]);
    color(arr3[2]);
    Console.Write(" {0} ", arr3[2]);
    Console.WriteLine();
    color(arr3[0]);
    Console.Write("   |");
    color(arr3[1]);
    Console.Write("   |");
    color(arr3[2]);
    Console.Write("   ");
    Console.WriteLine();
    Console.BackgroundColor = ConsoleColor.Black;
}

bool findawinner(string[] arr1, string[] arr2, string[] arr3)
{
    bool winned = true;
    if (arr1[0] == "o" && arr1[1] == "o" && arr1[2] == "o")
    {
        Console.WriteLine("Игрок1 выиграл");
    }
    else if (arr2[0] == "o" && arr2[1] == "o" && arr2[2] == "o")
    {
        Console.WriteLine("Игрок1 выиграл");
    }
    else if (arr3[0] == "o" && arr3[1] == "o" && arr3[2] == "o")
    {
        Console.WriteLine("Игрок1 выиграл");
    }
    else if (arr1[0] == "o" && arr2[1] == "o" && arr3[2] == "o")
    {
        Console.WriteLine("Игрок1 выиграл");
    }
    else if (arr1[2] == "o" && arr2[1] == "o" && arr3[0] == "o")
    {
        Console.WriteLine("Игрок1 выиграл");
    }
    else if (arr1[0] == "o" && arr2[0] == "o" && arr3[0] == "o")
    {
        Console.WriteLine("Игрок1 выиграл");
    }
    else if (arr1[1] == "o" && arr2[1] == "o" && arr3[1] == "o")
    {
        Console.WriteLine("Игрок1 выиграл");
    }
    else if (arr1[2] == "o" && arr2[2] == "o" && arr3[2] == "o")
    {
        Console.WriteLine("Игрок1 выиграл");
    }
    else if (arr1[0] == "x" && arr1[1] == "x" && arr1[2] == "x")
    {
        Console.WriteLine("Игрок2 выиграл");
    }
    else if (arr2[0] == "x" && arr2[1] == "x" && arr2[2] == "х")
    {
        Console.WriteLine("Игрок2 выиграл");
    }
    else if (arr3[0] == "x" && arr3[1] == "x" && arr3[2] == "x")
    {
        Console.WriteLine("Игрок2 выиграл");
    }
    else if (arr1[0] == "х" && arr2[1] == "x" && arr3[2] == "x")
    {
        Console.WriteLine("Игрок2 выиграл");
    }
    else if (arr1[2] == "x" && arr2[1] == "x" && arr3[0] == "x")
    {
        Console.WriteLine("Игрок2 выиграл");
    }
    else if (arr1[0] == "x" && arr2[0] == "x" && arr3[0] == "x")
    {
        Console.WriteLine("Игрок2 выиграл");
    }
    else if (arr1[1] == "х" && arr2[1] == "x" && arr3[1] == "x")
    {
        Console.WriteLine("Игрок2 выиграл");
    }
    else if (arr1[2] == "x" && arr2[2] == "х" && arr3[2] == "x")
    {
        Console.WriteLine("Игрок2 выиграл");
    }
    else
    {
        winned = false;
    }
    return winned;
}
void color(string symbol)
{
    if (symbol == "o")
    {
        Console.BackgroundColor = ConsoleColor.Red;
    }
    else if (symbol == "x")
    {
        Console.BackgroundColor = ConsoleColor.Green;
    }
    else
    {
        Console.BackgroundColor = ConsoleColor.Black;
    }
}
void choice(string[] arr1, string[] arr2, string[] arr3, string symbol, string position)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i] == position)
        {
            arr1[i] = symbol;
        }
    }
    for (int i = 0; i < arr2.Length; i++)
    {
        if (arr2[i] == position)
        {
            arr2[i] = symbol;
        }
    }
    for (int i = 0; i < arr3.Length; i++)
    {
        if (arr3[i] == position)
        {
            arr3[i] = symbol;
        }
    }
}
string[] arr1 = new string[3] { "1", "2", "3" };
string[] arr2 = new string[3] { "4", "5", "6" };
string[] arr3 = new string[3] { "7", "8", "9" };
string symbol = "o";
for (int i = 0; i < 9; i++)
{
    Console.WriteLine("Введите позицию. Игрок " + symbol + " ходит");
    draw(arr1, arr2, arr3);
    string position = Console.ReadLine();
    choice(arr1, arr2, arr3, symbol, position);
     
   
    if (symbol == "o")
    {
        symbol = "x";
    }
    else if (symbol == "x")
    {
        symbol = "o";
    }
    if (findawinner(arr1, arr2, arr3))
    {
        draw(arr1, arr2, arr3);
        break;
    }
   Console.Clear();
}
