// See https://aka.ms/new-console-template for more information


void draw(string[] arr1, string[] arr2, string[] arr3) 
{ 
Console.WriteLine("   |   |   ");
Console.WriteLine(" {0} | {1} | {2} ", arr1[0], arr1[1], arr1[2]);
Console.WriteLine("___|___|___");
Console.WriteLine("   |   |   ");
Console.WriteLine(" {0} | {1} | {2} ", arr2[0], arr2[1], arr2[2]);
Console.WriteLine("___|___|___");
Console.WriteLine("   |   |   ");
Console.WriteLine(" {0} | {1} | {2} ", arr3[0], arr3[1], arr3[2]);
Console.WriteLine("   |   |   ");
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
    if (findawinner(arr1, arr2, arr3))
    {
        break;
    }
    if (symbol == "o")
    {
        symbol = "x";
    }
    else if (symbol == "x") 
    {
        symbol = "o";
    }
    Console.Clear();
}