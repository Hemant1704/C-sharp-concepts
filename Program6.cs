using System;


namespace Lecture_1
{
	class Program6{
		/*
			In this we are lerning about methods in c sharp.
			a) Methods are also called functions. Both these terms are inter changeable
			general syntax is:
			access_modifier return_type method_name(parameters){
		
			}
			access modifier : where we want the method to be accessed ==> protection level
			return type : what type of data does the method returns.
			
			b) static and non static methods :So we can see that in the main method we have written static keyword
			whereas in the evenNumbers method i have not added the static keyword. It means that to invoke the evenNumbers 
			method i need to use a instance of the Program6 class.
			Whereras the main method is static method which can be called using the class name itself we do not require a 
			instance of the class.

			c) Method parameters
			There can be 4 types of parameters in c sharp:
				1. Value parameters : in this we pass the values of variables to the method.
				
				2. Reference parameters :
						Let us understand this in little bit details. Suppose i have a value i and i pass it into a function that modifies its value
						like int i = 0;  i pass this to func(int j){ j = 101;} now as i pass i it should change i value to 101 but instead of this i 
						will remain same 0 if we print it.
						To make changes to i we need to send a refernce to the method which will have the location of the variable i.
						This is called pass by refernce.
						Example : func(ref int j); and we pass it by func(ref i); now a new j variable will be created but will point to the same memory location.
				
				3. Output parameter: we these we can store our outputs in certain variables those are passed as output parameters to functions. I have written an
				example below in the code section.
		
				4. Parameter arrays : If we want to make our parameters optional than we use this. Here params keyword is used and then we do not need to pass
				the paramter. I have shown an example below in the main method. Also this must be the last paramter in the list of parameters. Also we can have
				only one paramter array.
			*/


		static void Main(string[] args) {
			
			// calling the method inside the class
			// I cannot call like evenNumbers(20); as this is not a static method i need to make a instance and then call it

			Program6 p = new Program6();
			p.evenNumbers1(20);

			// the second even numbers method can be called directly as it is static method.
			// in c sharp we cannot call it by instance whereas in java and cpp we can.
			evenNumbers2();

			// Example for output parameters
			int sum = 0;
			int product = 0;
			sumProduct(4,5,out sum,out product);
			

			// Example for params keyword - because i have used params keyword in my method thus no need to pass the array of numbers it is optional

			ParamsMethod();
		}

		public void evenNumbers1(int val) {
			// printing even numbers upto value val
			for (int i =2; i <= val; i+=2) {
				Console.WriteLine(i);
			}
		}
		public static void evenNumbers2(int val)
		{
			// printing even numbers upto value val
			for (int i = 2; i <= val; i += 2)
			{
				Console.WriteLine(i);
			}
		}

		public static void sumProduct(int n1, int n2, out int sum, out int prod) {
			sum = n1 + n2;
			prod = n1 * n2;
		}

		public static void ParamsMethod(params int[] Numbers) {
			foreach (int i in Numbers) {
				Console.WriteLine(i);
			}
		} 
	}
}
