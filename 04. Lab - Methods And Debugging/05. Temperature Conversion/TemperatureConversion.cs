using System;

class TemperatureConversion
{
    static double ConvertFahrenheit(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    
    static void Main()
    {
        double fahrenheit = double.Parse(Console.ReadLine());
        double celsius = ConvertFahrenheit(fahrenheit);
        Console.WriteLine($"{celsius:f2}");

    }
}

