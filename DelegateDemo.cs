using System;

public delegate void SampleDelegate(int x, int y);

class MathOperations
    {
        public void Add(int a, int b)
        {
           Console.WriteLine("Add Result: {0}", a + b);
        }
        public void Subtract(int x, int y)
        {
           Console.WriteLine("Subtract Result: {0}", x - y);
        }

        public void Multiplication(int j, int k)
        {
           Console.WriteLine("Multiplication Result: {0}", j * k);
        }
    }

class Program{
	static void Main(string [] args){
		MathOperations math = new MathOperations();
		//SampleDelegate sample = math.Add;
      //multicast delegate
      // sample += math.Subtract;
      // sample += math.Multiplication;
      // sample(90, 4);

      // single delegate
      // sample = math.Subtract;


      //Pass Method as Parameter using Delegate
      SampleMethod(math.Add, 9,7);
      SampleMethod(math.Subtract, 8, 7);
      SampleMethod(math.Multiplication, 9, 8);
	}

   static void SampleMethod(SampleDelegate sample, int a, int b)
       {
           sample(a, b);
       }
}