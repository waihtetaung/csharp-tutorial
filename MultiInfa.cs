using System;

interface IName{
	void GetName(string name);
}

interface IAge{
	void GetAge(int age);
}

interface IWork{
	void GetWork(string work);
}

public class User: IName, IAge, IWork{
	public void GetName(string name){
		Console.WriteLine("Name : {0}", name);
	}

	public void GetAge(int age){
		Console.WriteLine("Age : {0}", age);
	}

	public void GetWork(string work){
		Console.WriteLine("Work : {0}", work);
	}
}

public struct UserOne: IName, IAge, IWork{
	public void GetName(string name){
		Console.WriteLine("Name : {0}", name);
	}

	public void GetAge(int age){
		Console.WriteLine("Age : {0}", age);
	}

	public void GetWork(string work){
		Console.WriteLine("Work : {0}", work);
	}
}

class Program{
	static void Main(string [] args){
		User user = new User();
		user.GetName("Wai Htet");
		user.GetAge(24);
		user.GetWork("Jedi Master");

		UserOne userOne;
		userOne.GetName("Bruce Wayne");
		userOne.GetAge(26);
		userOne.GetWork("Batman");
	}
}