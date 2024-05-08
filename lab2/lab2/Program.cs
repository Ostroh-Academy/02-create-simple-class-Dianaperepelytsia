using System;

class Sum
{
    private double a;

    public Sum(double a)
    {
        this.a = a;
    }

    public double CalculateSum()
    {
        double sum = 0;
        for (int i = 1; i <= 3; i++)
        {
            sum += a / (i * (i + 1));
        }
        return sum;
    }

    public static double InputValue()
    {
        Console.WriteLine("Enter the value of a:");
        double value;
        while (!double.TryParse(Console.ReadLine(), out value))
        {
            Console.WriteLine("Incorrect format. Please enter a number.");
        }
        return value;
    }
}

class Program
{
    static void Main(string[] args)
    {
        double a = Sum.InputValue();
        Sum sumObject = new Sum(a);
        double result = sumObject.CalculateSum();
        Console.WriteLine("Sum: " + result);
    }
}

