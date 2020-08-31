using System;

namespace FractionCalculator
{
    public class Fraction
    {
        #region Attributes
        private int _numerator;
        private int _denominator;
        #endregion

        #region Propertys
        public int Numerator { get => _numerator; set => _numerator = value; }
        public int Denominator { get => _denominator; set => _denominator = value; }
        #endregion

        #region Constructors
        public Fraction()
        {
            this._numerator = 1;
            this._denominator = 1;
        }

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new Exception("The denominator can never be zero (0)!");
            }
            else
            {
                this.Numerator = numerator;
                this.Denominator = denominator;
            }
        }
        #endregion

        #region Worker
        private int Euklid(int numerator, int denominator)
        {
            if (denominator == 0)
                return numerator;
            else
                return Euklid(denominator, numerator % denominator);
        }

        public void Add(Fraction fraction)
        {
            Fraction solution = new Fraction();
            solution.Numerator = (Numerator * fraction.Denominator) + (fraction.Numerator * Denominator);
            solution.Denominator = (Denominator * fraction.Denominator);
            int gcf = Euklid(solution.Numerator, solution.Denominator);
            Console.WriteLine($"Solution: {solution.Numerator / gcf}/{solution.Denominator / gcf}");
        }
        public void Subtract(Fraction fraction)
        {
            Fraction solution = new Fraction();
            solution.Numerator = (Numerator * fraction.Denominator) - (fraction.Numerator * Denominator);
            solution.Denominator = (Denominator * fraction.Denominator);
            int gcf = Euklid(solution.Numerator, solution.Denominator);
            Console.WriteLine($"Solution: {solution.Numerator / gcf}/{solution.Denominator / gcf}");
        }
        public void Multiply(Fraction fraction)
        {
            Fraction solution = new Fraction();
            solution.Numerator = (Numerator * fraction.Numerator);
            solution.Denominator = (Denominator * fraction.Denominator);
            int gcf = Euklid(solution.Numerator, solution.Denominator);
            Console.WriteLine($"Solution: {solution.Numerator / gcf}/{solution.Denominator / gcf}");
        }
        public void Divide(Fraction fraction)
        {
            Fraction solution = new Fraction();
            solution.Numerator = (Numerator * fraction.Denominator);
            solution.Denominator = (Denominator * fraction.Numerator);
            int gcf = Euklid(solution.Numerator, solution.Denominator);
            Console.WriteLine($"Solution: {solution.Numerator / gcf}/{solution.Denominator / gcf}");
        }
        #endregion
    }
}
