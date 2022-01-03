////using System;

////namespace GenericExample
////{
////    class Program
////    {
////        static void Main(string[] args)
////        {
////            OurGen<int> obji = new OurGen<int>(12);
////            OurGen<string> objs = new OurGen<string>("Sam");
////            obji.Display();
////            objs.Display();
////            Console.ReadKey();
////        }
////    }
////}
////using System.Collections;
////using System;
////using System.Collections.Generic;
////using GenericExample;

////namespace MyExample
////{
////    public class Program
////    {
////        public static void Main()
////        {
////            //ArrayList mylist = new ArrayList {
////            //12,
////            //"Sam",
////            //12.45,
////            //'A'};
////            //foreach (var item in mylist)
////            //{
////            //    Console.WriteLine(item +" Datatype: ->"+item.GetType());
////            //}
////            //List<int> mylist = new List<int>
////            //{ 12,
////            //34,45,
////            //56,
////            //78};
////            //foreach (var item in mylist)
////            //{
////            //    Console.WriteLine(item);
////            //}
////            //List<string> mylist = new List<string>
////            //{"Sam",
////            //"Raj",
////            //"Gohar",
////            //"Vinit",
////            //"Jayant"};
////            //foreach (var item in mylist)
////            //{
////            //    Console.WriteLine(item);
////            //}
////            //Console.WriteLine("Count : "+mylist.Count);
////            //Console.WriteLine("Capacity :"+mylist.Capacity);
////            //mylist.Add("Rajiv");
////            //mylist.Add("Nitin");
////            //mylist.Add("Raj");
////            //mylist.Add("Sunita");
////            //Console.WriteLine("After Adding 3 more items");
////            //Console.WriteLine("Count : " + mylist.Count);
////            //Console.WriteLine("Capacity :" + mylist.Capacity);
////            //mylist.Remove("Rajiv");
////            //foreach (var item in mylist)
////            //{
////            //    Console.WriteLine(item);
////            //}
////            //Console.WriteLine("After Removing item from index 2");
////            //mylist.RemoveAt(2);
////            //foreach (var item in mylist)
////            //{
////            //    Console.WriteLine(item);
////            //}
////            //List of Employee 
////            //Share it through the chat
////            //5 
////            //            List<Emp> listEmps = new List<Emp>
////            //            {  new Emp {Id=1,Name="Sam",Desig="Tester",DOJ=new DateTime (day:09,month:09,year:2017) },

////            //            new Emp { Id = 2, Name = "Rohan", Desig = "Devloper", DOJ = new DateTime(day:08, month: 02, year: 2015) },
////            //               new Emp {Id=04,Name="Vinit",Desig="Devloper",DOJ=new DateTime(day:09, month:12, year:2012) },

////            //new Emp
////            //{ Id = 6, Name = "Dishant", Desig = "Developer", DOJ = new DateTime(day: 12, month: 12, year: 2012) },
////            //            };
////            //            Console.WriteLine("Employee List");
////            //            foreach (var e in listEmps)
////            //            {
////            //                Console.WriteLine("ID:"+e.Id);
////            //                Console.WriteLine("Name:" + e.Name);
////            //                Console.WriteLine("Designation:" + e.Desig);
////            //                Console.WriteLine("Date of Joining:" + e.DOJ.ToShortDateString());
////            //                Console.WriteLine("\n");

////            //            }
////            //Console.ReadKey();

////            //    List<Emp> listEmps = new List<Emp>() {
////            //    new Emp
////            //    {
////            //        Id = 12,
////            //        Name = "Sam",
////            //        Desig = "Manager",
////            //        DOJ = new DateTime(day: 12, month: 12, year: 2014)
////            //    },
////            //        new Emp
////            //    {
////            //        Id = 13,
////            //        Name = "Sunita",
////            //        Desig = "Developer",
////            //        DOJ = DateTime.Parse("12/12/2012")
////            //}};

////            //    Console.WriteLine("ID \t Name \t Designation \t Date of Joining");
////            //    foreach (var e in listEmps)
////            //    {
////            //        Console.Write(e.Id+"\t");
////            //        Console.Write( e.Name+"\t");
////            //        Console.Write(e.Desig+"\t\t");
////            //        Console.Write(e.DOJ.ToShortDateString());
////            //        Console.Write("\n");

////            //    }
////            //    Console.ReadKey();

////        }
////    } 
////}
//using GenericExample;
//using System;
//using System.Collections.Generic;
//using System.Collections;

//namespace SecondEx
//{
//    public  class MyClass
//    {
//        //public List<Emp> empList;
//        public Dictionary<int, Emp> empList;
//     public MyClass()
//        {
//            empList = new Dictionary<int, Emp>
//            {
//                { 1, new Emp() { Id = 1, Name = "Jai", Desig = "Manager", DOJ = new DateTime(day: 03, month: 12, year: 2019) } },
//                { 10, new Emp() { Id = 12, Name = "Vijay", Desig = "Manager", DOJ = new DateTime(day: 12, month: 12, year: 2019) } },
//                { 4, new Emp() { Id = 13, Name = "Rohit", Desig = "Manager", DOJ = new DateTime(day: 12, month: 12, year: 2019) } },
//                { 5, new Emp() { Id = 14, Name = "Raj", Desig = "Manager", DOJ = new DateTime(day: 12, month: 12, year: 2019) } },
//            };

//        }
//    }
//    public class Program
//    {
//        public static void Main()
//        {
//            //ArrayList arrayList;
//            //Hashtable hashtable;
//            //SortedList sortedList;
//            //Stack stack;
//            //Queue queue;
//            //List<int> list;
//            //Dictionary<int, string> dictionary;
//            //SortedList<int, string> gsortedList;
//            //Stack<int> mystack;
//            //Queue<int> mqueue;

//            Console.WriteLine("ID \t Name \t Designation \t Date of Joining");
//            MyClass objc = new MyClass();
//            foreach (var e in objc.empList.Values)
//            {
//                Console.Write(e.Id + "\t");
//                Console.Write(e.Name + "\t");
//                Console.Write(e.Desig + "\t\t");
//                Console.Write(e.DOJ.ToShortDateString());
//                Console.Write("\n");

//            }
//            Console.ReadKey();


//        }
//    }
//}
//Constraint on Generic
using System;
namespace GenericExample
{
    public class Program
    {
        public static void Main()
        {
            MyGen<int, string> objis = new MyGen<int, string>(12, "Sameer");
            objis.Show();

            MyGen<char, string> objsc = new MyGen<char,string>('A',"Class-One");
            objsc.Show();
            MyGen<int, Emp> objie = new MyGen<int, Emp>(2, new Emp { Id = 1, Name = "Sam", Desig = "Mgr" });
            objie.Show();
            Console.ReadKey();


        }
    }
}