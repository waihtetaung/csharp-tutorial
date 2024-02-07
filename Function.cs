using System;

namespace Tutlane
{
     class Program
     {
         static void Main(string[] args)
         {
            Program p = new Program();
            Console.WriteLine(p.add(3,4));
            Console.WriteLine(p.greet());
            p.doSomething("Life Depend on liver");
            p.blahBlah();
            Square(3,4);
            Console.Read();
         }

         public int add(int x, int y){
         	return x + y;
         }

         public string greet(){
            return "Hello Csharp";
         }

         public void doSomething(string quote){
             Console.WriteLine(quote);
         }

         public void blahBlah(){
             Console.WriteLine("Blah Blah");
         }

         public static void Square(int a, int b)
         {
             a = a * a;
             b = b * b;
             Console.WriteLine(a + " " + b);
         }
     }
} 