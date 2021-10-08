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
                int    :   
                uint   :
                long   :
                ulong  :
            */
        }
    }
}
