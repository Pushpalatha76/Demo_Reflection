using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Demo_Reflection
{
    class Dynamic_Object
    {
        public Dynamic_Object() { }

        public Dynamic_Object(String Msg) { }

        public void First_Method() 
        {
            Console.WriteLine("Inside First Method");
        }

        public void Second_Method() 
        {
            Console.WriteLine("Inside Second Method");
        }
    }
}
