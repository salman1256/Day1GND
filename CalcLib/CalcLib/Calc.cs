using System;
namespace CalcLib
{    public class Calc
    {
        public double Add(double num1, double num2)
        {
            double result = num1 + num2;
            return result; }
        public double Diff(double num1, double num2)
        {
            double result = num1 - num2;
            return result;
        }
        public double Multi(double num1, double num2)
        {
            double result = num1*num2;
            return result;
        }
        public double Div(double num1, double num2)
        {
            double result = num1/ num2;
            return result;
        }

    }
}
