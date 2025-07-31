// See https://aka.ms/new-console-template for more information

// ref : https://asciiset.com/

static void main()
{
    Dictionary<string,char> table = new Dictionary<string, char>();
    table.Add("TOP_LEFT", '╔');
    table.Add("TOP", '═');
    table.Add("TOP_RIGHT", '╗');
    table.Add("LEFT", '║');
    table.Add("RIGHT", '║');
    table.Add("BOTTOM_LEFT", '╚');
    table.Add("BOTTOM", '═');
    table.Add("BOTTOM_RIGHT", '╝');

    string text = "Hello, World!";

    // draw top
    Console.Write($"{table["TOP_LEFT"]}");
    for(int i = 0;i<text.Length + 2; i++) 
    {
        Console.Write($"{table["TOP"]}");
    }
    Console.WriteLine($"{table["TOP_RIGHT"]}");

    // draw text
    Console.WriteLine($"{table["LEFT"]} {text} {table["RIGHT"]}");

    //draw the bottom
    Console.Write($"{table["BOTTOM_LEFT"]}");
    for (int i = 0; i < text.Length + 2; i++)
    {
        Console.Write($"{table["TOP"]}");
    }
    Console.WriteLine($"{table["BOTTOM_RIGHT"]}");


    Console.ReadLine();
}

main();