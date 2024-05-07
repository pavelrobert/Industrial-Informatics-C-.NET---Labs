class Ex5
{
    public static double ArithmeticMean(int[] arr)
    {
        double sum = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum/arr.Length;
    }
    public static double GeometricMean(int[] arr)
    {
        double product = 1;
        for (int i = 0;i < arr.Length;i++)
        {
            product *= arr[i];
        }
        return Math.Pow(product, 1.0/arr.Length);
    }
    public static void Main(string[] args)
    {
        int[] arr= new int[5];
        int i;
        Console.WriteLine("Enter 5 numbers: ");

        for(i = 0; i < arr.Length; i++)
        {
            Console.Write("Element {0} is : ", i+1);
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("\nElements in the array are: ");

        for (i = 0; i < arr.Length; i++)
        {
            Console.Write("{0} ", arr[i]);
        }
        Console.Write("\n");

        double arithmeticMean = ArithmeticMean(arr);
        double geometricMean = GeometricMean(arr);

        Console.WriteLine("Arithmetic Mean is: {0}", arithmeticMean);
        Console.WriteLine("Geometric Mean is: {0}", geometricMean);

    }
}