using System;

namespace ConstructorChange{
	class Changing{
		public Changing(){
			Console.WriteLine("Hello, ");
		}


		public Changing(string a): this(){
			Console.WriteLine(a);
		}

		public Changing(string a, string b): this("Wellcome"){
			Console.WriteLine(a + " " +b);
		}
	}

	class Program{
		static void Main(string [] args){
			Changing change = new Changing("to" , "my World!");

		}
	}
}