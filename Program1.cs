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
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}",name);
        }
    }
}
