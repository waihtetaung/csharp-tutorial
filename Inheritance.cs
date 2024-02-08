using System;

public class A{
	public string name;

	public void getName(){
		Console.WriteLine("Name : {0}", name);
	}
}

public class B : A{
	public int age;

	public void getAge(){
		Console.WriteLine("Age : {0}", age);
	}
}

public class C : B{
	public string work;

	public void getWork(){
		Console.WriteLine("Work : {0}", work);
	}
}


public class Pragram{
	static void Main(string [] args){
		C c = new C();
		c.name = "Wai Htet";
		c.age = 24;
		c.work = "Jedi Master";
		c.getName();
		c.getAge();
		c.getWork();
	}
}