using System;

namespace Constructor{
	class User{
		public User(){
			Console.WriteLine("User Instance is created");
		}

		~User(){
			Console.WriteLine("User Instance is destoryed.");
		}

		public int add(int x, int y){
			return x + y;
		}
	}

	class Program{
		static void Main(string [] args){
			User user = new User();
			//Console.WriteLine(user.add(7,8));
			// User user1 = new User();
			// Console.WriteLine(user.add(3,2));
		}
	}
}