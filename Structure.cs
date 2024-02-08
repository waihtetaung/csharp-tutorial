using System;

namespace Structure{
	struct User{
		public const string name = "John Doe";
		public string location;
		public int age;

		public User(string location, int age){
			this.location = location;
			this.age = age;
		}
	}

	class Program{
		static void Main(string[] args){
			User u = new User("US", 30);
			User u1;
			Console.WriteLine("Name: {0}, Location: {1}, Age: {2}", User.name, u.location, u.age);
			u1.location = "Canada";
			u1.age = 32;
			Console.WriteLine("Name: {0}, Location: {1}, Age: {2}", User.name, u1.location, u1.age);
			Console.ReadLine();
		}
	}
}