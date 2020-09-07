/* Author: Christopher Winter
 * Datei: Main.cs
 * Beschreibung: Dies ist die Main Datei sie gibt die Lösungen von Beispielrechnungen aus
 */

namespace FractionCalculator
{
    public class FractionCalculator
    {
        public static void Main(string[] args)
        {
            Fraction a = new Fraction();
            Fraction b = new Fraction();
            Fraction solution = new Fraction();

            a.Numerator = 3;
            a.Denominator = 4;
            b.Numerator = 7;
            b.Denominator = 9;

            solution.Assign(a.Add(b));
            solution.Assign(a.Subtract(b));
            solution.Assign(a.Multiply(b));
            solution.Assign(a.Divide(b));
        }
    }
}
