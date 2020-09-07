/*
 * Author: Christopher Winter
 * Datei: Fraction.cs
 * Beschreibung: Diese Klasse erlaubt das Erstellen von Brüchen mit den dazugehörigen Methoden.
 */

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
        private int Euclid(int numerator, int denominator)
        {
            if (denominator == 0)
                return numerator;
            else
                return Euclid(denominator, numerator % denominator);
        }

        public Fraction Add(Fraction fraction)
        {
            Fraction solution = new Fraction();
            solution.Numerator = (Numerator * fraction.Denominator) + (fraction.Numerator * Denominator);
            solution.Denominator = (Denominator * fraction.Denominator);
            int gcf = Euclid(solution.Numerator, solution.Denominator);
            return new Fraction(solution.Numerator / gcf, solution.Denominator / gcf);
        }
        public Fraction Subtract(Fraction fraction)
        {
            Fraction solution = new Fraction();
            solution.Numerator = (Numerator * fraction.Denominator) - (fraction.Numerator * Denominator);
            solution.Denominator = (Denominator * fraction.Denominator);
            int gcf = Euclid(solution.Numerator, solution.Denominator);
            return new Fraction(solution.Numerator / gcf, solution.Denominator / gcf);
        }
        public Fraction Multiply(Fraction fraction)
        {
            Fraction solution = new Fraction();
            solution.Numerator = (Numerator * fraction.Numerator);
            solution.Denominator = (Denominator * fraction.Denominator);
            int gcf = Euclid(solution.Numerator, solution.Denominator);
            return new Fraction(solution.Numerator / gcf, solution.Denominator / gcf);
        }
        public Fraction Divide(Fraction fraction)
        {
            Fraction solution = new Fraction();
            solution.Numerator = (Numerator * fraction.Denominator);
            solution.Denominator = (Denominator * fraction.Numerator);
            int gcf = Euclid(solution.Numerator, solution.Denominator);
            return new Fraction(solution.Numerator / gcf, solution.Denominator / gcf);
        }
        public Fraction Assign(Fraction fraction)
        {
            Numerator = fraction.Numerator;
            Denominator = fraction.Denominator;
            Console.WriteLine($"{Numerator} / {Denominator}");
            return new Fraction(Numerator, Denominator);
        }

        #endregion
    }
}
