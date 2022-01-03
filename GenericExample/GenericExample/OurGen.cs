using System;
namespace GenericExample
{
    public class OurGen<T>
    {
        T ourField;
        public OurGen(T param)
        {
            ourField = param;
        }
        public void Display()
        {
            Console.WriteLine("Value: {0} \n DataType: {1}",ourField ,ourField.GetType());
        }
    }
}
