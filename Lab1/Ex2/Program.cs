class Ex2
{
    public static void PerformOperation(double num1, double num2, string symbol)
    {
        double result;

        switch (symbol)
        {
            case "+":
                result = num1 + num2;
                Console.WriteLine("Addition:" + result);
                break;
            case "-":
                result = num1 - num2;
                Console.WriteLine("Subtraction:" + result);
                break;
            case "*":
                result = num1 * num2;
                Console.WriteLine("Multiplication:" + result);
                break;
            case "/":
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine("Division:" + result);
                }
                else
                {
                    Console.WriteLine("Division by zero is not allowed!");
                }
                break;
            default:
                Console.WriteLine("Wrong input");
                break;
        }
    }
    static void Main(string[] args)
    {
        Console.Write("Enter first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter symbol (/,+,-,*): ");
        string symbol = Console.ReadLine();

        Ex2 calculator = new Ex2();
        Ex2.PerformOperation(num1, num2, symbol);

        Console.ReadLine();
    }
}
