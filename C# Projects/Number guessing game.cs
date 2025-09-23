using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Random rand = new Random();
        int secret = rand.Next(1, 101);
        int num = -1;
        int attempts = 0;
        
        Console.WriteLine("Guess an number between 1 to 100");
        
        while( num != secret)
        {
          num = int.Parse(Console.ReadLine());
        
          if(num < secret)
          {
            Console.WriteLine("too low");
          }
          else if(num > secret)
          {
            Console.WriteLine("too high");
          }
          else
          {
            Console.WriteLine("You won");
          }
        }
    }
}