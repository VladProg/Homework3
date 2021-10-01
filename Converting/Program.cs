using System;
using System.Globalization;
using System.Threading;

namespace Converting
{
    class Program
    {
        static void Main()
        {
            Converter converter = new(26.63, 30.90);
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.Write("Value: ");
            double value = double.Parse(Console.ReadLine());
            Console.WriteLine($"{value:f2} UAH = {converter.UahToUsd(value):f2} USD");
            Console.WriteLine($"{value:f2} UAH = {converter.UahToEur(value):f2} EUR");
            Console.WriteLine($"{value:f2} USD = {converter.UsdToUah(value):f2} UAH");
            Console.WriteLine($"{value:f2} EUR = {converter.EurToUah(value):f2} UAH");
        }
    }
}
