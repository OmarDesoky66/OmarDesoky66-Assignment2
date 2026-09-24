namespace Calculator;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("CALCULATOR");


        Console.WriteLine("--------------------------------");

        int num1;
        int num2;
        char operation;
        int result = 0;

        
        Console.Write("Enter the first number: ");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("--------------------------------");


        Console.Write("Enter the second number: ");
        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("--------------------------------");




        Console.Write("Enter operation (+, -, *, /): ");
        operation = char.Parse(Console.ReadLine());


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
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide by zero!");
                    return;
                }
                result = num1 / num2;
                break;


        }

        Console.WriteLine($"Result: {result}");

            




        
    }
}
