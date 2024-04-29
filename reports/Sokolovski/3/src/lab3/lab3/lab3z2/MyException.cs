namespace StackCalculator;

public class MyException
{
    public static void ErrorCommandNotFound(string command)
    {
        Console.WriteLine($"Error: Command: {command} not found");
    }

    public static void ErrorWrongCountOfArgument(string command)
    {
        Console.WriteLine($"Error: wrong count of argument \" {command} \" ");
    }

    public static void ErrorVariableNotFound(string command)
    {
        Console.WriteLine($"Error: variable not found \" {command} \" ");
    }
}