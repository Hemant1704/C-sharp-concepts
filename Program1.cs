using System;

/*
 Namespace:
    Collections of various classes is called a namespace for example System is a namespace.
    Better practice is to make a separate file for a class rather than making the class in 
    the same file.
  */
namespace Lecture_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // User input taken
            string name = Console.ReadLine();

            // Place holder syntax to print the variable.
            Console.WriteLine("Hello {0}",name);

            /*Basic data types in c#
                sbyte  :  -128 to 127 signed 8 bit
                byte   :   0 to 255 unsigned
                char   :   unicode 16 bit character 
                short  :   signed 16 bit integer
                int    :   signed 32 bit integer
                uint   :   unsigned 32 bit integer
                long   :   signed 64 bit
                ulong  :   unsigned 64 bit
            We also have float and double values which differ in precision.
            */


            // Escape sequence : For characters like " we need to add a escape sequence to print it.Example is shown
            string str = "\"hemant\"";
            Console.WriteLine(str);

            // Verbatim string: Tells compiler to ignore the escape characters and commpile as a normal string
            // Example @"//" will give // whereas normal "//" will represent / (used in path definition to a folder)
            string s1 = @"my name is\\hemant";
            string s2 = "my name is \\ hemant";
            Console.WriteLine("With verbatim string @ "+s1);
            Console.WriteLine("Without verbatim string "+s2);

            // Operators are similar to other languages like Java and C++
        }
    }
}
