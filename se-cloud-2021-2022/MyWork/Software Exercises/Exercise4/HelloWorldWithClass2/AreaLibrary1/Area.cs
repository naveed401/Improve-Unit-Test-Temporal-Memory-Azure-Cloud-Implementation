using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public void someline()
        {
            Console.WriteLine("Completed My SWE Exercise4");

        }

    }
    public class Class2

    {
        int area;
        public int Area()
        {

            int length;
            int width;

            Console.WriteLine("Please write the length of your rectangle: ");
            length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please write the breadth of your rectangle: ");
            width = Convert.ToInt32(Console.ReadLine());

            area = length * width;

            return area;
        }
    }
}

namespace AreaLibrary1
{
    public class Area
    {

    }
}