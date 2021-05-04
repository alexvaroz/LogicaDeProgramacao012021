using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bom dia!");
        Console.WriteLine("Digite a temperatura em Celsius desejada:");
        double temperaturaCelsius = double.Parse(Console.ReadLine());
        double temperaturaFahrenheit = ConverterCelsiusParaFahrenheit(temperaturaCelsius);
        Console.WriteLine($"A temperatura em Fahrenheit é {temperaturaFahrenheit}ºF");
        Console.ReadLine();
    }

    static double ConverterCelsiusParaFahrenheit(double temperaturaCelsius)
    {
    return (temperaturaCelsius * 9 / 5) + 32; 
    }
}

