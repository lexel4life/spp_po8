using System;
using System.Collections.Generic;

namespace StackCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string input = "";
            if (args.Length > 0)
            {
                // Чтение команд из файла
                input = File.ReadAllText(args[0]);
            }
            else
            {
                // Чтение команд из стандартного ввода
                Console.WriteLine("Enter commands... {Type 'exit' to end}");
                while (true)
                {
                    string str = Console.ReadLine();
                    if (str != "exit")
                    {
                        input += Console.ReadLine();
                        input += '\n';
                    }
                    
                    break;
                    
                }
            }
            string[] commands = input.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            foreach (string command in commands)
            {
                string[] commandText = command.Split(' ');
                switch (commandText[0].Trim().ToUpper())
                {
                    case "#":
                        // Комментарий
                        break;
                    case "POP":
                        Context.Stack.Pop();
                        break;
                    case "PUSH":
                        if (commandText.Length != 2)
                        {
                            MyException.ErrorWrongCountOfArgument(command);
                        }
                        else
                        {
                            double value;
                            if (double.TryParse(commandText[1], out value) || Context.Parameters.TryGetValue(commandText[1], out value))
                            {
                                Context.Stack.Push(value);
                            }
                            else
                            {
                                MyException.ErrorVariableNotFound(commandText[1]);
                            }
                            
                        }
                        
                        break;
                    case "+":
                        switch (commandText.Length)
                        {
                            case 1:
                                Context.Stack.Push(Context.Stack.Pop() + Context.Stack.Pop());
                                break;
                            case 2:
                                double value;
                                if (double.TryParse(commandText[1], out value) || Context.Parameters.TryGetValue(commandText[1], out value))
                                {
                                    Context.Stack.Push(Context.Stack.Pop() + value);
                                }
                                else
                                {
                                    MyException.ErrorVariableNotFound(commandText[1]);
                                }
                                break;
                            case 3:
                                double value1 , value2;
                                if ((double.TryParse(commandText[1], out value1) && double.TryParse(commandText[2], out value2)) || (Context.Parameters.TryGetValue(commandText[1], out value1) && Context.Parameters.TryGetValue(commandText[1], out value2)))
                                {
                                    Context.Stack.Push(value1 + value2);
                                }
                                else
                                {
                                    MyException.ErrorVariableNotFound(command);
                                }
                                break;
                            default:
                                MyException.ErrorWrongCountOfArgument(command);
                                break;
                        }
                        break;
                    case "-":
                        switch (commandText.Length)
                        {
                            case 1:
                                Context.Stack.Push(Context.Stack.Pop() - Context.Stack.Pop());
                                break;
                            case 2:
                                double value;
                                if (double.TryParse(commandText[1], out value) || Context.Parameters.TryGetValue(commandText[1], out value))
                                {
                                    Context.Stack.Push(Context.Stack.Pop() - value);
                                }
                                else
                                {
                                    MyException.ErrorVariableNotFound(commandText[1]);
                                }
                                break;
                            case 3:
                                double value1 , value2;
                                if ((double.TryParse(commandText[1], out value1) && double.TryParse(commandText[2], out value2)) || (Context.Parameters.TryGetValue(commandText[1], out value1) && Context.Parameters.TryGetValue(commandText[1], out value2)))
                                {
                                    Context.Stack.Push(value1 - value2);
                                }
                                else
                                {
                                    MyException.ErrorVariableNotFound(command);
                                }
                                break;
                            default:
                                MyException.ErrorWrongCountOfArgument(command);
                                break;
                        }
                        break;
                    
                    case "*":
                        switch (commandText.Length)
                        {
                            case 1:
                                Context.Stack.Push(Context.Stack.Pop() * Context.Stack.Pop());
                                break;
                            case 2:
                                double value;
                                if (double.TryParse(commandText[1], out value) || Context.Parameters.TryGetValue(commandText[1], out value))
                                {
                                    Context.Stack.Push(Context.Stack.Pop() * value);
                                }
                                else
                                {
                                    MyException.ErrorVariableNotFound(commandText[1]);
                                }
                                break;
                            case 3:
                                double value1 , value2;
                                if ((double.TryParse(commandText[1], out value1) && double.TryParse(commandText[2], out value2)) || (Context.Parameters.TryGetValue(commandText[1], out value1) && Context.Parameters.TryGetValue(commandText[1], out value2)))
                                {
                                    Context.Stack.Push(value1 * value2);
                                }
                                else
                                {
                                    MyException.ErrorVariableNotFound(command);
                                }
                                break;
                            default:
                                MyException.ErrorWrongCountOfArgument(command);
                                break;
                        }
                        break;
                    case "/":
                        switch (commandText.Length)
                        {
                            case 1:
                                Context.Stack.Push(Context.Stack.Pop() / Context.Stack.Pop());
                                break;
                            case 2:
                                double value;
                                if (double.TryParse(commandText[1], out value) || Context.Parameters.TryGetValue(commandText[1], out value))
                                {
                                    Context.Stack.Push(Context.Stack.Pop() / value);
                                }
                                else
                                {
                                    MyException.ErrorVariableNotFound(commandText[1]);
                                }
                                break;
                            case 3:
                                double value1 , value2;
                                if ((double.TryParse(commandText[1], out value1) && double.TryParse(commandText[2], out value2)) || (Context.Parameters.TryGetValue(commandText[1], out value1) && Context.Parameters.TryGetValue(commandText[1], out value2)))
                                {
                                    Context.Stack.Push(value1 / value2);
                                }
                                else
                                {
                                    MyException.ErrorVariableNotFound(command);
                                }
                                break;
                            default:
                                MyException.ErrorWrongCountOfArgument(command);
                                break;
                        }
                        break;
                    case "SQRT":
                        if (commandText.Length != 2)
                        {
                            MyException.ErrorWrongCountOfArgument(command);
                        }
                        else
                        {
                            double value;
                            if (double.TryParse(commandText[1], out value) || Context.Parameters.TryGetValue(commandText[1], out value))
                            {
                                Context.Stack.Push(Math.Sqrt(value));
                            }
                            else
                            {
                                MyException.ErrorVariableNotFound(commandText[1]);
                            }
                            
                        }
                        break;
                    case "PRINT":
                        Console.WriteLine($"Element on top: {Context.Stack.Peek()}");
                        break;
                    case "DEFINE":
                        if (commandText.Length != 2)
                        {
                            MyException.ErrorWrongCountOfArgument(command);
                        }
                        else
                        {
                            string paramName = commandText[1];
                            double paramValue = Context.Stack.Pop();
                            Context.Parameters[paramName] = paramValue;
                        }
                        break;
                    default:
                        MyException.ErrorCommandNotFound(command);
                        break;
                }
            }
                
            
        }
    }
}
