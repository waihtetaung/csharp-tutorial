using System;

interface IUser{
	void GetDetails(string name);
}

public class User:IUser{
	public void GetDetails(string name){
		Console.WriteLine("Name : {0}" , name);
	}
}

public class User1:IUser{
	public void GetDetails(string name){
		Console.WriteLine("Name : {0}" , name);
	}
}

class Program{
	static void Main(string [] args){
		IUser user = new User();
		user.GetDetails("Karl Marx");
		IUser user1 = new User1();
		user1.GetDetails("Adam Smith");
	}
}