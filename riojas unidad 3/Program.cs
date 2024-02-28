using System;

class SimpleCalculator
{
    private double operand1;
    private double operand2;

    // Constructor to initialize with random data
    public SimpleCalculator()
    {
        Random random = new Random();
        operand1 = random.Next(1, 10);
        operand2 = random.Next(1, 10);
        Console.WriteLine($"Random data generated: Operand1={operand1}, Operand2={operand2}");
    }

    // Addition method
    public double Add()
    {
        return operand1 + operand2;
    }

    // Subtraction method
    public double Subtract()
    {
        return operand1 - operand2;
    }

    // Multiplication method
    public double Multiply()
    {
        return operand1 * operand2;
    }

    // Division method
    public double Divide()
    {
        if (operand2 != 0)
        {
            return operand1 / operand2;
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
            return double.NaN;
        }
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of SimpleCalculator
        SimpleCalculator calculator = new SimpleCalculator();

        // Perform calculations and display results
        Console.WriteLine($"Addition: {calculator.Add()}");
        Console.WriteLine($"Subtraction: {calculator.Subtract()}");
        Console.WriteLine($"Multiplication: {calculator.Multiply()}");
        Console.WriteLine($"Division: {calculator.Divide()}");
    }
}



