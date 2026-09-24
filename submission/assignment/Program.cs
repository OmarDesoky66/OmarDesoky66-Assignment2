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
        while (!int.TryParse(Console.ReadLine(), out num1))
        {
            Console.Write("Invalid number! Enter the first number again: ");
        }
        Console.WriteLine("--------------------------------");


        Console.Write("Enter the second number: ");
        while (!int.TryParse(Console.ReadLine(), out num2))
        {
            Console.Write("Invalid number! Enter the second number again: ");
        }

        Console.WriteLine("--------------------------------");




        Console.Write("Enter operation (+, -, *, /): ");
        while (!char.TryParse(Console.ReadLine(), out operation) ||
        (operation != '+' && operation != '-' && operation != '*' && operation != '/'))
        {
            Console.Write("Invalid operation! Enter (+, -, *, /): ");
        }


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
