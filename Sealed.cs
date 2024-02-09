using System;

public class A
    {
       public virtual void GetInfo()
       {
          Console.WriteLine("Base Class A Method");
       }
       public virtual void Test()
       {
          Console.WriteLine("Base Class A Test Method");
       }
    }

public class B:A{
	public sealed override void GetInfo(){
		Console.WriteLine("Delivered Class B Class");
	}

	public override void Test(){
		Console.WriteLine("Delivered Test B Class");
	}
}

public class C:B{
	public override void GetInfo(){
		Console.WriteLine("Delivered From A,B");
	}

	public override void Test(){
		Console.WriteLine("Deliver From A,B Test Class C");
	}
}

class Program{
	static void Main(string [] args){
		C c = new C();
		c.Test();
		//c.GetInfo();
	}
}