using System;

namespace Tutlane
{
    class Program
    {
        static void Main(string[] args)
        {
           for (int i = 1; i < 10; i++)
           {
              if (i == 5)
              {
                 goto endloop;
              }
              Console.WriteLine("i value: {0}", i);
           }
           endloop: Console.WriteLine("The end");
           Console.WriteLine("Press Enter Key to Exit..");
           Console.ReadLine();
        }
    }
} 