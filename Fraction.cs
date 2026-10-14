using System;

namespace Lab2
{
    /// <summary>
    /// Сущность Дробь: числитель и знаменатель.
    /// Операции возвращают новую дробь, исходные не меняются.
    /// Дробь автоматически сокращается при создании.
    /// </summary>
    public class Fraction
    {
        private int numerator;
        private int denominator;

        public int Numerator
        {
            get { return numerator; }
        }

        public int Denominator
        {
            get { return denominator; }
        }

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Знаменатель не может быть нулём.");
            }

            // Знак держим в числителе
            if (denominator < 0)
            {
                numerator = -numerator;
                denominator = -denominator;
            }

            // Сокращаем дробь
            int gcd = Gcd(Math.Abs(numerator), denominator);
            this.numerator = numerator / gcd;
            this.denominator = denominator / gcd;
        }

        // НОД двух чисел (алгоритм Евклида)
        private int Gcd(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // ---------- Сложение ----------

        public Fraction Sum(Fraction other)
        {
            int newNum = this.numerator * other.denominator
                       + other.numerator * this.denominator;
            int newDen = this.denominator * other.denominator;
            return new Fraction(newNum, newDen);
        }

        public Fraction Sum(int value)
        {
            return new Fraction(this.numerator + value * this.denominator,
                                this.denominator);
        }

        // ---------- Вычитание ----------

        public Fraction Minus(Fraction other)
        {
            int newNum = this.numerator * other.denominator
                       - other.numerator * this.denominator;
            int newDen = this.denominator * other.denominator;
            return new Fraction(newNum, newDen);
        }

        public Fraction Minus(int value)
        {
            return new Fraction(this.numerator - value * this.denominator,
                                this.denominator);
        }

        // ---------- Умножение ----------

        public Fraction Multiply(Fraction other)
        {
            return new Fraction(this.numerator * other.numerator,
                                this.denominator * other.denominator);
        }

        public Fraction Multiply(int value)
        {
            return new Fraction(this.numerator * value, this.denominator);
        }

        // ---------- Деление ----------

        public Fraction Divide(Fraction other)
        {
            if (other.numerator == 0)
            {
                throw new ArgumentException("Деление на ноль.");
            }
            return new Fraction(this.numerator * other.denominator,
                                this.denominator * other.numerator);
        }

        public Fraction Divide(int value)
        {
            if (value == 0)
            {
                throw new ArgumentException("Деление на ноль.");
            }
            return new Fraction(this.numerator, this.denominator * value);
        }

        public override string ToString()
        {
            return numerator + "/" + denominator;
        }
    }
}