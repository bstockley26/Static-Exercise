using System;
namespace StaticExercise
{
	public class TempConverter
	{
		public TempConverter()
		{
		}
		public static double FahrenheitToCelsius(double numOne)
		{
			var fehrenheit = numOne;

			var celsius = (fehrenheit - 32) * 0.5556;

			Console.WriteLine($"{celsius} degrees Celsius");

			return celsius;
			
		}
		public static double CelsiusToFahrenheit(double numOne)
		{
			var celsius = numOne;

			var fahrenheit = (celsius * 1.8) + 32;

			Console.WriteLine($"{fahrenheit} degrees Fahrenheit");

			return fahrenheit;

			
				
		}
	
	}
}

