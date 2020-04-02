using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200402_WriteLine
{
	class Program
	{
		/*02.04.2020 Andrej Kopp
		 * Ausgabe und Eingabe von Werten
		 * WriteLine() und ReadLine()
		 */
		static void Main(string[] args)
		{
			double a, b, c, min, max;
			string action;

			max = 1000000.0;
			min = -1000000.0;

			//Werte für a und b einlesen
			Console.WriteLine("Wie ist die erste Zahl?");
			a = double.Parse(Console.ReadLine());
			if (a > max)
			{
				a = max;
				Console.WriteLine("Fehler: Zahl ist außerhalb des erlaubten Zahlenbereichs. Automatische Korrektur.");
			}
			else if (a < min)
			{
				a = min;
				Console.WriteLine("Fehler: Zahl ist außerhalb des erlaubten Zahlenbereichs. Automatische Korrektur.");
			}

			Console.WriteLine("Wie ist die zweite Zahl?");
			b = double.Parse(Console.ReadLine());

			if (b > max)
			{
				b = max;
				Console.WriteLine("Fehler: Zahl ist außerhalb des erlaubten Zahlenbereichs. Automatische Korrektur.");
			}
			else if (b < min)
			{
				b = min;
				Console.WriteLine("Fehler: Zahl ist außerhalb des erlaubten Zahlenbereichs. Automatische Korrektur.");
			}

			Console.WriteLine("Wählen Sie eine Operation: '+' '-' '*' '/'");
			action = Console.ReadLine();

			switch (action)
			{
				case "+":
						c = a + b;
						Console.WriteLine(c);
					break;
				case "-":
						c = a - b;
						Console.WriteLine(c);
					break;
				case "*":
						c = a * b;
						Console.WriteLine(c);
					break;
				case "/":
					if (b == 0)
					{
						Console.WriteLine("Fehler: Kann nicht durch Null teilen. Breche ab.");
					}
					else
					{
						c = a / b;
						Console.WriteLine(c);
					}
					break;
				default:
					Console.WriteLine("Fehler. Unbekannte Aktion.");
					break;
			}
		}
	}
}
