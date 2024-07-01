// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Simple Calculator");
Console.WriteLine("=================");
Console.Write("Enter the first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter an operator (+, -, *, /): ");
var operation = Console.ReadKey().KeyChar;
Console.WriteLine();

Console.Write("Enter the second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

double result = 0;

switch (operation)
{
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
}

            Console.WriteLine($"Result: {result}");
