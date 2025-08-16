using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number : ");
        int num = int.Parse(Console.ReadLine());
        
        int a = num % 2;
        
        if( a == 0 )
        Console.WriteLine("Even");
        
        else
        Console.WriteLine("Odd");
    }
}