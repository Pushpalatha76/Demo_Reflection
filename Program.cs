using System;
using System.Reflection;

namespace Demo_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo Reflection.....!");

            Type T = typeof(string);
            Console.WriteLine("Type of Name:\t{0}", T.Name);
            Console.WriteLine("Full na,e of the type defined :\t{0}", T.FullName);
            Console.WriteLine("Type of Assembly in which it is defined :\t{0}", T.Assembly);
            Console.WriteLine("Information about Base Type :\t{0}", T.BaseType);

            Dynamic_Object MyObj1 = new Dynamic_Object();
            MyObj1.First_Method();
            MyObj1.Second_Method();
            dynamic MyObj2 = new Dynamic_Object();
            MyObj2.First_Method();
            MyObj2.Second_Method();
        }
    }
}
