using System;

class Calculate{
	public void AddNumber(int x, int y){
		Console.WriteLine("x + y = {0}" , x + y);
	}

	public void AddNumber(int x, int y, int z){
		Console.WriteLine("x + y + z = {0}" , x + y +z );
	}
}

class Program{
	static void Main(string [] args){
		//Run-Time Poly is overloading method
		Calculate cal = new Calculate();
		cal.AddNumber(7,8);
		cal.AddNumber(7,8,7);
	}
}