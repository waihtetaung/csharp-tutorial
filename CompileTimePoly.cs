using System; 

public class BClass{
	public virtual void greeting(){
		Console.WriteLine("Hello Something.");
	}
}

public class DClass:BClass{
	public override void greeting(){
		Console.WriteLine("Konichiwa minasan!");
	}
}

class Program{
	static void Main(string [] args){
		//Compile-Time Poly is override method
		BClass b = new BClass();
		b.greeting();
		DClass d = new DClass();
		d.greeting();
	}
}