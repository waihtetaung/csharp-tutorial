using System;

namespace cObject{
	public class User{
		public static void Main(string [] args){
			getUser user = new getUser(1, "Waihtet", 24);
			user.getUserDetails();
			Console.ReadLine();
		}
	}

	public class getUser{
		private int id;
		private string name;
		private int age;

		public getUser(int id, string name, int age){
			this.id = id;
			this.name = name;
			this.age = age;
		}

		public int Id{
			get{return id;}
			set{id = value;}
		}

		public string Name{
			get{return name;}
			set{name = value;}
		}

		public int Age{
            	get{return age;}
            	set{age = value;}   
		}

		public void getUserDetails(){
			Console.WriteLine("Id : {0}, Name: {1}, Age: {2}", id, name, age);
		}
	}
}