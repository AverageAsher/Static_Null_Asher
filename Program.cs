using System;

// Define a static class named Calculate
public static class Calculate
{
    // Declare a public static float field named result
    public static float result;

    // Static constructor that initializes the result to 0.0f
    static Calculate()
    {
        result = 0.0f;
    }

    // Method to add two integers and return the result
    public static int Add(int a, int b)
    {
        result = a + b;
        return (int)result;
    }

    // Overloaded method to add two floats and return the result
    public static float Add(float a, float b)
    {
        result = a + b;
        return result;
    }

    // Method to subtract two integers and return the result
    public static int Subtract(int a, int b)
    {
        result = a - b;
        return (int)result;
    }

    // Overloaded method to subtract two floats and return the result
    public static float Subtract(float a, float b)
    {
        result = a - b;
        return result;
    }

    // Method to multiply two integers and return the result
    public static int Multiply(int a, int b)
    {
        result = a * b;
        return (int)result;
    }

    // Overloaded method to multiply two floats and return the result
    public static float Multiply(float a, float b)
    {
        result = a * b;
        return result;
    }

    // Method to divide two integers and return the result
    public static int Divide(int a, int b)
    {
        // Check if the divisor is not zero
        if (b != 0)
        {
            result = (float)a / b;
            return (int)result;
        }
        else
        {
            Console.WriteLine("Cannot divide by zero!");
            return 0;
        }
    }

    // Overloaded method to divide two floats and return the result
    public static float Divide(float a, float b)
    {
        // Check if the divisor is not zero
        if (b != 0)
        {
            result = a / b;
            return result;
        }
        else
        {
            Console.WriteLine("Cannot divide by zero!");
            return 0.0f;
        }
    }
}

// Main program class
class Program
{
    // Main method
    static void Main(string[] args)
    {
        // Integer arguments
        int intNum1 = 10;
        int intNum2 = 5;

        // Print section header
        Console.WriteLine("Integer Results:");

        // Call each method with integer arguments and print the result
        Console.WriteLine("Addition: " + Calculate.Add(intNum1, intNum2));
        Console.WriteLine("Subtraction: " + Calculate.Subtract(intNum1, intNum2));
        Console.WriteLine("Multiplication: " + Calculate.Multiply(intNum1, intNum2));
        Console.WriteLine("Division: " + Calculate.Divide(intNum1, intNum2));

        // Floating-point arguments
        float floatNum1 = 10.5f;
        float floatNum2 = 2.5f;

        // Print section header
        Console.WriteLine("\nFloating Point Results:");

        // Call each method with floating-point arguments and print the result
        Console.WriteLine("Addition: " + Calculate.Add(floatNum1, floatNum2));
        Console.WriteLine("Subtraction: " + Calculate.Subtract(floatNum1, floatNum2));
        Console.WriteLine("Multiplication: " + Calculate.Multiply(floatNum1, floatNum2));
        Console.WriteLine("Division: " + Calculate.Divide(floatNum1, floatNum2));
         }
    }
