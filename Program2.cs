using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_1
{
    class Program2{
        static void Main(string[] args) {
            Console.WriteLine("Welcome to program2");

            /*
            ---------------------------------------------------------------------------------
            a)
            So before moving on let us have discussion on types in c sharp.
            C# has mainly 2 kind of types:
             i) Value types - int,float,double,boolean,enums,etc
             ii) Reference types - interface, class, delegates, arrays.
            Some of the above mentioned names we will study later on.

            ---------------------------------------------------------------------------------
            b)
            By default value types are non nullable which means they cannot have a null value stored in them.
            To make value types nullable we need to add a ?
            int? i = null;---> Now this is valid

            ----------------------------------------------------------------------------------
            c)
            But what is the need of such nullable types?
            Suppose there is a form in which there is boolean field either user has to select yes 
            or select no but the field is nnot mandatory so the user leaves it empty. Now we need 
            to have nullable type in order to make the user amnswer neutral.
            Thus when we use c# with databases and applications we require nullable data types in
            such scenarios.

            -----------------------------------------------------------------------------------
            d) 
            We also need to convert the nullable type back to value type if we want to store it 
            in a variable of value type.
            int value = nullable_type_variable.Value;
            Or
            int value = (int)nullable_type_variable
            -----------------------------------------------------------------------------------
             */

            // Let us see an example

            int? ticketsOnSale = 24;
            int ticketsRemaining;
            if (ticketsOnSale == null)
            {
                ticketsRemaining = 0;
            }
            else{
                // Here we need to convert the nullable type back to int type
                ticketsRemaining = ticketsOnSale.Value;
                // or use (int) ticketsOnSale
            }
            Console.WriteLine("Tickets Available " + ticketsRemaining);

            /*
            e)
            Now instead of writing all the above stuff we can use something called null coalescing operator
            int ticketsRemaining = ticketsOnSale ?? 0;
            Now if ticketsOnSale is null 0 will be stored in ticketsRemaining else the current value

            Thus this operator reduces the number of lines of code.
             */
        }
    }
}
