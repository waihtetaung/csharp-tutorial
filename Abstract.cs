using System;

	public abstract class Shape{
		public abstract double GetArea();

		public void Display(){
			Console.WriteLine($"Area: {GetArea()}");
		}
	}

	public class Triangle : Shape{
		private double _baseValue;
		private double _heightValue;

		public Triangle(double baseValue, double heightValue){
			this._baseValue = baseValue;
			this._heightValue = heightValue;
		}

		public double Base
			{
				get{return _baseValue;}
				set{_baseValue = value;}
			}

		public double Height
			{
				get{return _heightValue;}
				set{_heightValue = value;}
			}
		
		public override double GetArea(){
			return 0.5 * _baseValue * _heightValue;
		}
	}


	public class Circle : Shape{
		private double _radius;

		public Circle(double Radius){
			this._radius = Radius;
		}

		public double Radius{
				get{return _radius;}
				set{_radius = value;}
		}

		public override double GetArea(){
			 return Math.PI * _radius * _radius;
		}
	}

	class Calculate{
		static void Main(string [] args){
			Triangle tri = new Triangle(3,4);
			tri.Display();
			Circle cir = new Circle(12);
			cir.Display();
		}
	}