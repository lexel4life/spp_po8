string input;
using (StreamReader reader = new StreamReader("input.txt"))
{ 
    input = reader.ReadToEnd();
}

List<Char> numbers = new List<Char>();
foreach (var ch in input)
{
    if (Char.IsNumber(ch))
    {
        numbers.Add(ch);
    }
}

Console.WriteLine(numbers[numbers.Count/2]);