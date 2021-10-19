using System;
namespace Lecture_1
{
	class Program10
	{
		/*
		In this we are going to learn about inheritence in c sharp.
		Inheritence : It is the property through which a class can inherit the methods or properties
		of the parent class.
		child class : parent class


		 */
		static void main(string[] args) {
			Child c1 = new Child("Hemant","Chauhan");
			c1.GetFullName();
		}
	}
	class Parent {
		string fname;
		string lname;
        public Parent()
        {

        }
		Parent(string fname,string lname) {
			this.fname = fname;
			this.lname = lname;
		}
		void GetFullName() {
			Console.WriteLine("Full name is {0}",(fname+lname));
		}
	}
	// child class inherits the parent class thus it will have all the data and methods of parent class
	class Child : Parent{
		int age;
	}
}
