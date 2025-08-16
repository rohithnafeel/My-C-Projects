using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("What's your name ? ");
        string name = Console.ReadLine ();
        
        Console.WriteLine ("What's your age ? ");
        int age = int.Parse(Console.ReadLine());
        
        Console.WriteLine ("Height in meters : ");
        float height = float.Parse(Console.ReadLine());
        
        Console.WriteLine ("Weight in kg : ");
        double weight = double.Parse(Console.ReadLine());
        
        double BMI = weight / (height * height);
        
        Console.WriteLine("\nProfile : ");
        Console.WriteLine("Name :" + name);
        Console.WriteLine("Age :" + age);
        Console.WriteLine("Height :" + height);
        Console.WriteLine("Weight :" + weight);
        Console.WriteLine("BMI :" + BMI);
        
        if(BMI < 18.5)
        Console.WriteLine("Category :Underweight");
        
        else if( BMI >= 18.5 && BMI < 25 )
        Console.WriteLine("Category :Normalweight");
        
        else if( BMI >= 25 && BMI < 30 )
        Console.WriteLine("Category :Overweight");
        
        else
        Console.WriteLine("Category :Obese");
    }
}