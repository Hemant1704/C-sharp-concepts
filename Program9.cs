using System;

namespace Lecture_1 {
	class Program8
	{
		/*
		In this we will learn about static and instance members.
		So in the given example where i have taken a circle class we have intitally taken 2 member variables
		pi value and radius value. But if we notice the value of pi is same for every object so if we create
		1000 objects it will store this pi value 1000 times but which is un necessary thus we can decalre this 
		as a static variable(which does not change).

		Now this field will get attached to the class and will be stored only once. Thus it is better to make 
		the variables that are same for all the objects as static.

		Also now as the field is not a member of class we cannot refer it using this keyword, we need to refer it
		using the class name. Example Circle.PI

		Also to intialise static fields we can use static constructors that we do not need to call. Also this also
		will be only called one. Only the instance constructor will be called again and again.
		 */
		static void Main(string[] args){
			Circle c1 = new Circle(1);
			Console.WriteLine("Area is {0}", c1.CalculateArea());
		}
	}
	class Circle {
		static float _PI;
		int _Radius;
		static Circle() {
			Circle._PI = 3.141F;
		}
		public Circle(int Radius) {
			this._Radius = Radius;
		}
		public float CalculateArea() {
			return Circle._PI * this._Radius * this._Radius;
		}

	}

}
