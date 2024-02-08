using System;

namespace Partial{
	public partial class User{
		partial void GetUserDetails(string a, string b);
	}

	public partial class User{
		public User(string a, string b){
			GetUserDetails(a,b);
		}

		partial void GetUserDetails(string x, string y){
			Console.WriteLine("Name: " + x);
			Console.WriteLine("Location: " + y);
		}
	}

	class Program{
		static void Main(string [] args){
			User user = new User("Karl Marx", "US");
		}
	}
}