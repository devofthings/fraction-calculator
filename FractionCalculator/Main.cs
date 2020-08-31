namespace FractionCalculator
{
    public class FractionCalculator
    {
        public static void Main(string[] args)
        {
            Fraction a = new Fraction();
            Fraction b = new Fraction();

            a.Numerator = 4;
            a.Denominator = 5;
            b.Numerator = 3;
            b.Denominator = 7;

            a.Add(b);
            a.Subtract(b);
            a.Multiply(b);
            a.Divide(b);
        }
    }
}
