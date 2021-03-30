using System;

namespace Lab_4
{
    public class Derivatives_Calculator
    {
        public double Sin(double x)
        {
            return Math.Round(Math.Cos(x), 2);
        }
        public double Cos(double x)
        {
            return (-1) * Math.Round(Math.Sin(x), 2);
        }
    }
}
