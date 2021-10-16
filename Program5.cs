using System;

/// <summary>
/// Summary description for Class1
/// </summary>

namespace Lecture_1{
	class Program5
	{
		static void main(string[] args){
			/*
			In this we are going to learn about the loops in c sharp
			So the loops are similar to c++ and java 

			 */

			//a) For loop : example for for loop to print first 10 numbers
            for(int i = 1; i <= 10; i++) {
				Console.WriteLine(i);
			}

			// b) While loop : similar task done using while loop
			int val = 1;
			while (val <= 10) {
				Console.WriteLine(val);
				val += 1;
			}

			//c) Do while loop example 
			val = 1;
			do
			{
				Console.WriteLine(val);
				val += 1;
			}
			while (val <= 10);

			// d) for each loop 
			int[] numbers = { 1,2,3,4,5};
			foreach(int num in numbers) {
				// for each element in the numbers array do this
				Console.WriteLine(num);
			}

			/* e) Break and continue
			break is used to end the loop immediately
			whereas continue is used to continue the loop directly from that point.
			It will not execute the rest of the statements after it if it is used.
			 */
			// Let us see the example of printing the numbers between 4 and 8 only looping through 1 to 10

			val = 1;
			while (val <= 10) {
                if (val < 4)
                {
					val += 1;
					continue;
                }
				if (val > 8)
				{
					break;
				}
				else {
					Console.WriteLine("Number is "+val);
					val += 1;
				}

			}

		}
	}
}
