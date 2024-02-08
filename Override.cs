using System;

public class BClass{
	public virtual string Name{get; set;}
	public virtual void GetInfo(){
		Console.WriteLine("Life Depend On Liver");
	}
}

public class DClass : BClass{
	private string name;

	public override string Name{
		get{return name;}
		set{
			if(!string.IsNullOrEmpty(value)){
				name = value;
			}else{
				name = "No Value";
			}
		}
	}

	public override void GetInfo(){
		Console.WriteLine("Shakepear Quote");
	}
}

class Program{
	static void Main(string [] args){
		DClass d = new DClass();
		d.GetInfo();
		BClass b = new BClass();
		b.GetInfo();
	}
}