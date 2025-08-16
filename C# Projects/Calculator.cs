using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter number 1 : ");
        int a = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter number 2 : ");
        int b = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Choose : +, -, *, /, %");
        string c = Console.ReadLine();
        
        switch(c)
        {
            case "+":
            Console.WriteLine("Result: " + (a+b));
            break;
            
            case "-":
            Console.WriteLine("Result: " + (a-b));
            break;
            
            case "*":
            Console.WriteLine("Result: " + (a*b));
            break;
            
            case "/":
                if (b != 0)
                    Console.WriteLine("Result: " + ((float)a / b));
                else
                    Console.WriteLine("Error: Cannot divide by zero");
                break;
            
            case "%":
                if (b != 0)
                    Console.WriteLine("Result: " + (a % b));
                else
                    Console.WriteLine("Error: Cannot find remainder with zero");
                break;
            
            default:
                Console.WriteLine("Invalid operator");
                break;
        }
    }
}