int n = 10;
string path = "";
switch (args.Length)
{
    case 1:
        path = args[0];
        break;
    case 2:
        path = args[1];
        n = Convert.ToInt32(args[0]);
        break;
    case 3:
        path = args[2];
        n = Convert.ToInt32(args[1]);
        break;
    default:
        Console.WriteLine("Wrong input");
        return -1;
}

string text = "";
using (StreamReader reader = new StreamReader(path))
{
    for (int i = 0; i < n; i++)
    {
        text += reader.ReadLine();
        text += "\n";
    }
}

Console.WriteLine(text);
return 0;