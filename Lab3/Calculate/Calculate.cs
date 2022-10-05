using System;

namespace Lab33.Service
{
    public class Calculate: ICalculate
    {
        public double NegativeEquation(double A, double x)
        {
            return -1 * Math.Sqrt((A - x) * (8 * A + x) * (8 * A + x) / (A * 27));
        }

        public double PositiveEquation(double A, double x)
        {
            return Math.Sqrt((A - x) * (8 * A + x) * (8 * A + x) / (A * 27));
        }
    }
}
