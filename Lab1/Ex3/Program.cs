class Ex3
{
    public static double fromCtoF(double C)
    {
        double result1;
        result1 = C * 9 / 5 + 32;
        return result1;
    }
    public static double fromFtoC(double F)
    {
        double result2;
        result2 = (F - 32) * 5 / 9;
        return result2;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a value for Celsius grd: ");
        double C = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter a value for Farenheit grd: ");
        double F = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Input 1) For C to F or 2) For F to C: ");

        int input = Convert.ToInt32(Console.ReadLine());

        switch (input)
        {
            case 1:
                Console.WriteLine(Ex3.fromCtoF(C));
                break;
            case 2:
                Console.WriteLine(Ex3.fromFtoC(F));
                break;
            default:
                Console.WriteLine("Wrong input!");
                break;
        }

    }
}