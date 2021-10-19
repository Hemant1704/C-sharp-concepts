using System;
namespace Lecture_1
{
	class Program8{

		/*
		In this file we are going to learn about classes.
		Class : It consists of data and behavior. Behavior is nothing but the methods of the class
		I have given an example of Customer class in the given file.
		
		Constructor : It helps us to intialise the data variables or data members of the class.
		We can write our owm constructors for the class. If we do not write the constructor definition
		.NET defines constructor itself so that we can create our own objects for the class. It will be 
		a default parameterless constructor.

		Now suppose someone does not provide anything as first name and last name we can define the constructor
		in the below manner
		Customer() : this("No first name","No last name"){};
		Now this parameterless constructor will call the other constructor.

		Also very important thing to note is to remember to make the protection level according to the use
		To use it in the main method we need to make the constructor public as well.

		Also the constructors can be overloaded and used accordingly.
		 */
		static void Main(string[] args){ 
			// In the main method we need to create an instance of the class.
			// Here the constructor will be used.
			Customer c1 = new Customer("Hemant","Chauhan");
			string myFullName = c1.GetFullName();
			Console.WriteLine(myFullName);
		}
	}

	class Customer {
		// _ represents that it is the member of the class Customer
		string _fname;
		string _lname;

	// Parameter less constructor
	public Customer() : this("No first name", "no last name")
	{ }

		// Constructor of the customer class
		public Customer(string firstName,string lastName) {
			this._fname = firstName;
			this._lname = lastName;
		}

		// let us create a method that will give us the full name of the customer
		public string GetFullName() {
			return (this._fname+this._lname);
		}

		// this is a destructor which cleans up the resources the class was holding on to.
		~Customer() { 
			// clean up code will be written here
		}
	}
}
