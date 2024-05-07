class Ex4
{
    public double MaleWeight(int height, int age)
    {
        double maleWeight;
        maleWeight = height - 100 - ((height - 150) / 4.0) + ((age - 20) / 4.0);
        return maleWeight;
    }
    public double FemaleWeight(int height, int age)
    {
        double maleWeight;
        maleWeight = height - 100 - ((height - 150) / 2.5) + ((age - 20) / 6.0);
        return maleWeight;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the height: ");
        int height = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the gender for the person(m/f): ");
        char gender = Convert.ToChar(Console.ReadLine());

        Ex4 person = new Ex4();

        switch (gender)
        {
            case 'm':
                Console.WriteLine("The ideal weight for a " + age + " years old " + gender + " is: " + person.MaleWeight(height, age));
                break;
            case 'f':
                Console.WriteLine("The ideal weight for a " + age + " years old " + gender + " is: " + person.FemaleWeight(height, age));
                break;
            default:
                Console.WriteLine("Wrong gender inputed, try again!");
                break;
        }
    }
}