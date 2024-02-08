using System;

namespace GetSet{
	public class Properties{
		static void Main(string[] args)
         {
            Credential c = new Credential();
            Console.WriteLine(c.Age);
         }
	}

	public class Credential{
		
			private int age = 10;
            public int Age{
            	get{return age;}
            	set{age = value;}
            
		}
	}
}