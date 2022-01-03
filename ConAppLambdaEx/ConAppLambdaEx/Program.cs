//using System;
//namespace ConAppLambdaEx
//{
//    public delegate void MyDel(string name);
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string userName;
//            Console.WriteLine("Enter User Name");
//            userName = Console.ReadLine();
//            //MyDel del = delegate (string name)
//            //  {
//            //      Console.WriteLine("Welcome to Anoymous Method Mr.\\Ms. "+name);
//            //  };
//            MyDel del = s => { Console.WriteLine("Welcome to Lambdas Mr.\\Ms. " + s); };
//            del(userName);
//            Console.ReadKey();

//        }
//    }
//}
//Second Example
//using System;
//using System.Collections.Generic;

//namespace ConAppLambdaEx
//{

//    class Program
//    {
//        delegate bool IsPrimeEmp(Emp obje);
//        static void Main(string[] args)
//        {
//            List<Emp> listEmps = new List<Emp>
//            {
//            new Emp{ID=1,Name="Sam",Designation="Developer",Salary=65000 },
//            new Emp{ID=2,Name="Raj",Designation="Manager",Salary=90000 },
//            new Emp{ID=3,Name="Mohit",Designation="Developer",Salary=75000 },
//            new Emp{ID=4,Name="Ajeet",Designation="Tester",Salary=55000 },
//            new Emp{ID=5,Name="Niraj",Designation="Manager",Salary=92000 },
//            };
//            IsPrimeEmp isPrime = e => e.Designation == "Manager" && e.Salary >= 92000;
//            Console.WriteLine("List of  prime Employee");
//            Console.WriteLine("ID \t Name \t Designation \t \t Salary");
//            foreach (Emp e in listEmps)
//            {
//                if (isPrime(e))
//                {
//                    Console.WriteLine(e.ID+"\t"+e.Name+"\t"+e.Designation +"\t \t"+e.Salary);
//                }
//            }

//            Console.ReadKey();

//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
namespace ConAppLambdaEx
{

    class Program
    {
        
        static void Main(string[] args)
        {
            List<Emp> listEmps = new List<Emp>
            {
            new Emp{ID=1,Name="Sam",Designation="Developer",Salary=65000 },
            new Emp{ID=2,Name="Raj",Designation="Manager",Salary=90000 },
            new Emp{ID=3,Name="Mohit",Designation="Developer",Salary=75000 },
            new Emp{ID=4,Name="Ajeet",Designation="Tester",Salary=55000 },
            new Emp{ID=5,Name="Niraj",Designation="Manager",Salary=92000 },
            };
            string name;
            Console.WriteLine("Enter name to find out Employee Details");
            name = Console.ReadLine();
            var result = listEmps.Where(e => e.Name == name).ToList();
            foreach (var e in result)
            {
                Console.WriteLine(e.ID);
                Console.WriteLine(e.Designation);
            }
           


            Console.ReadKey();

        }
    }
}
