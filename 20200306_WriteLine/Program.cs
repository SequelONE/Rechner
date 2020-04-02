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
			double a, b, ergebnis, rest, min, max;

			min = Convert.ToDouble(-1000000.00);
			max = Convert.ToDouble(1000000.00);

			//Werte für a und b einlesen
			Console.WriteLine("Wie ist die erste Zahl?");
			a = Convert.ToDouble(Console.ReadLine());
			if(a > max || a < min)
			{
				a = Convert.ToDouble(999999);
			}
			
			Console.WriteLine("Wie ist die zweite Zahl?");
			b = Convert.ToDouble(Console.ReadLine());

			//reine Textausgabe
			//Console.WriteLine("5 + 12 = 17");

			//Addieren
			ergebnis = a + b;
			Console.WriteLine("{0} + {1} = {2}", a, b, ergebnis);
			//Minus
			ergebnis = a - b;
			Console.WriteLine("{0} - {1} = {2}", a, b, ergebnis);
			//Mal
			ergebnis = a * b;
			Console.WriteLine("{0} * {1} = {2}", a, b, ergebnis);
			//Teilen
			ergebnis = a / b;
			rest = a % b;
			Console.WriteLine("{0} / {1} = {2} Rest {3}", a, b, ergebnis, rest);
		}
	}
}
