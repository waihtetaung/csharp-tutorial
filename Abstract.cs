using System;

	public abstract class Shape{
		public abstract double getArea();

		public void Display(){
			Console.WriteLine($"Area: {getArea()}");
		}
	}

	public class Triangle : Shape{
		private double Base;
		private double Heigh;

		public Triangle(double Base, double Heigh){
			this.Base = Base;
			this.Heigh = Heigh;
		}

		public double base
			{
				get{return Base;}
				set{Base = value;}
			}

		public double eigh
			{
				get{return Heigh;}
				set{Heigh = value;}
			}
		
		public override double getArea(){
			return 0.5 * Base * Heigh;
		}
	}


	public class Circle : Shape{
		private double Radius;

		public Circle(double Radius){
			this.Radius = Radius;
		}

		public double radius{
				get{return Radius;}
				set{Radius = value;}
		}

		public override double getArea(){
			 return Math.PI * Radius * Radius;
		}
	}

	class Program{
		static void Main(string [] args){
			Triangle triangle = new Triangle(5,10);
			Circle circle = new Circle(12);

			triangle.Display();
			circle.Display();
		}
	}
