

class Program
{
    static void Main()
    {
        // First Code Snippet
        int celcius1 = 34;
        decimal temperature1 = ((celcius1 *9m/5) + 32);
        Console.WriteLine("The temperature is " + temperature1 + " fahrenheit");
        
        // Second Code Snippet
        int celcius2 = 34;
        decimal temperature2 = ((celcius2 * 9m / 5m) + 32m);
        Console.WriteLine("The temperature is " + Math.Round(temperature2) + " fahrenheit");
    }
}
