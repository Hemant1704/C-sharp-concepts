using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_1
{
    class Program4
    {



        static void main(string[] args)
        {
            /*
            a)
            In this we are going to study about very basics of arrays and comments in c sharp
            to declare an array
            int[] arr = new int[n]; where n is the size of the array
            strongly typed : as we can only store int if we declare int
            they cannot grow in size once initialised.

            */

            // let us create an array of names of students and try to print it
            string[] name = new string[3];
            name[0] = "Hemant";
            name[1] = "Ram";
            name[2] = "Shyam";
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
            /*
             b)
              Comments in c sharp 
              there are single line of comments and multiline then 
              currently we are writing in multiline comments
              also i have used comments previously so i think we are familiar with it
 
            */

            /*
            c)
            operators are ==> || and &&
            something new is | this single pipe it checks both condition even in or condition 
            but this will not make an impact on the output instead it increases are work.

            || && are called shortcircuit operators
             
             */


            /*
            d)
            if else statements 
            they are similar to java and c++
            let us take an example
            
            */
            bool var = true;
            if (var)
            {
                Console.WriteLine("var was true");
            }
            else {
                Console.WriteLine("var was false");
            }

            // e) switch case statements are same as java and c++
            int val = 1;
            switch (val) {
                case 1:
                    Console.WriteLine("Value was 1");
                    break;
                case 2:
                    Console.WriteLine("Value was 2");
                    break;
                default:
                    Console.WriteLine("Value was neither 1 nor 2");
                    break;
            }


        }




    }
}
