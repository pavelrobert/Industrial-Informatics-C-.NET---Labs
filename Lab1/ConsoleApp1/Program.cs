class Ex1
{
    public static int FibSeries(int n)
    {
        if (n == 0) return n;
        if (n == 1) return n;
        return FibSeries(n - 1) + FibSeries(n - 2);
    }
    public static void Main(string[] args)
    {
        Console.Write("Enter the length of the Fibonnaci Series: ");
        int length = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < length; i++)
        {
            Console.Write("{0} ", FibSeries(i));
        }
        Console.ReadKey();    
    }
}