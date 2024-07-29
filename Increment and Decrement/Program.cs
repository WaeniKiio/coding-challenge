

class Program
{
    static void Main()
    {
        int value = 2;
        value = value + 2;
        Console.WriteLine("First Increment:" + value);
        
        value += 3;
        Console.WriteLine("Second Increment:" + value);
        
        value++;
        Console.WriteLine("Third Increment :" + value);
        
        value = value - 1;
        Console.WriteLine("First Decrement:" + value);
        
        value -= 2;
        Console.WriteLine("Second Decrement:" + value);
        
        value--;
        Console.WriteLine("Third Decrement:" + value);
    }
}
