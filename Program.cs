using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("Simple calculator");
			Console.WriteLine();
			Console.ResetColor();

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Enter an arithmetic expression (for example, 2 + 3) or 'quit' to exit:");

			while (true)
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.Write(" > ");
				string input = Console.ReadLine();

				if (input.ToLower() == "quit")
				{
					break;
				}

				try
				{
					string[] parts = input.Split(' ');
					if (parts.Length != 3)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Invalid input format!!! Enter an arithmetic expression (for example, 2 + 3)");
						Console.ResetColor();
						continue;
					}

					double num1 = double.Parse(parts[0]);
					string operation = parts[1];
					double num2 = double.Parse(parts[2]);

					double result = 0;
					switch (operation)
					{
						case "+":
							result = num1 + num2;
							break;
						case "-":
							result = num1 - num2;
							break;
						case "*":
							result = num1 * num2;
							break;
						case "/":
							if (num2 == 0)
							{
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine("Error: division by zero is forbidden!");
								Console.ResetColor();
								continue;
							}
							result = num1 / num2;
							break;
						default:
							Console.ForegroundColor = ConsoleColor.Red;
							Console.WriteLine("Invalid operator!!! Use +, -, *, or /");
							Console.ResetColor();
							continue;
					}

					Console.WriteLine($"Result: {result}");
				}
				catch (FormatException)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Invalid number format!!! Please enter valid numbers!!!");
					Console.ResetColor();
				}
				catch (Exception ex)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine($"An error occurred: {ex.Message}");
					Console.ResetColor();
				}
			}

			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.WriteLine("Calculator is closed!");
			Console.ResetColor();
		}
	}
}