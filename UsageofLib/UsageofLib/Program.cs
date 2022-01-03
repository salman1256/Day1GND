using System;
using CalcLib;
namespace UsageofLib
{
    class Program
    {
        static void Main(string[] args)
        {    double n1, n2;
            Console.WriteLine("Enter First Number");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Choose operation");
            Console.WriteLine("1.Add \n 2.Diff \n 3. Multi  \n 4. Divison");
            int op = int.Parse(Console.ReadLine());
            Calc objc = new Calc();
            switch (op)
            {
                case 1:
                    {
                        Console.WriteLine("Result after adding {0} and {1} = \t {2}",n1,n2,objc.Add(n1,n2));
                        break; }
                case 2:
                    {
                        Console.WriteLine("Difference between {0} and {1} = \t {2}", n1, n2, objc.Diff(n1, n2));
                        break; }

                case 3:
                    {
                        Console.WriteLine("Result after multiplying {0} and {1} = \t {2}", n1, n2, objc.Multi(n1, n2));
                        break; }

                case 4:
                    {
                        Console.WriteLine("Result after dividing {0} by {1} = \t {2}", n1, n2, objc.Div(n1, n2));
                        break; }

                default:
                    {
                        Console.WriteLine("Invalid Opearation");
                        break; 
                    }
            }
            Console.ReadKey();
        }
    }
}
