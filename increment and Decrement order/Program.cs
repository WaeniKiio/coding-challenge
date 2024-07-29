using System;

class Program
{
    static void Main()
    {
        int value = 1;
        
        value++;
        Console.WriteLine("First: " + value); 
        
        Console.WriteLine("Second: " + value++); 
        
        Console.WriteLine("Third: " + value); 
        
        Console.WriteLine("Fourth: " + (++value)); 
        
        
    }
}
