using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_1
{
    class Program3
    {
        static void Main(string[] args)
        {
            /*
            a)
            In this we will learn about data type conversion like converting float to int.
            So there are 2 types of conversions :
            i) Implicit conversion:
                This is done bt the compiler when there is no loss of information that is the
                new type must be bigger size than the one we are converting.
                Example: converting int to float there is no problem but converting float to int is 
                a problem as the fractional part goes away so explicit conversion cannot be done.
            ii) Explicit conversion 
                In this we convert data types explicitly
                Example : int val = (int)(2.304);

             */

            // Implicit conversion
            int val1 = 2;
            float val2 = val1;
            Console.WriteLine(val2);

            // Explicit conversion
            float v1 = 1.04;
            int v2 = (int)(v1);
            Console.WriteLine(v2);

            // b) Parse : Converting string to integer.
            string data = "32";
            int d = int.Parse(data);
            Console.WriteLine("Parsed data "+d);

            /*
            c)
            tryParse : return boolean type whether the string can be converted to int or not
            We can also store value in a variable using this method.
            What we can do is create a variable int which we want to store the data.
            int store = 0;
            boolean canConvert = int.TryParse(string,store);
            If can be converted the data will be stored in store else it will remain zero.
             */

            data = "32g4";
            Boolean canConvert = int.TryParse(data);
            Console.WriteLine("Can data be parsed "+canConvert);




        }
    }
}
