using System;
namespace GenericExample
{
    public class MyGen<S,M> where S:struct where M:class
    {
        S field1;
        M field2;
        public MyGen(S para,M para2)
        {
            field1 = para;
            field2 = para2;
        }
        public void Show()
        {
            Console.WriteLine
            ("Value Stored in Field One is {0} \n DataType of Field One is {1}",field1,field1.GetType());
            Console.WriteLine
            ("Value Stored in Field Two is {0} \n DataType of Field Two is {1}", field2, field2.GetType());
        }
    }
}
