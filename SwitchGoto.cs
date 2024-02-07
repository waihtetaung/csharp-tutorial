using System;

namespace Tutlane
{
     class Program
     {
         static void Main(string[] args)
         {
             int i = 3, j = 0;
             switch (i)
             {
                 case 1:
                    j += 20;
                    Console.WriteLine("j value is {0}",j);
                    break;
                 case 2:
                    j += 5;
                    goto case 1;
                 case 3:
                    j += 30;
                    goto case 1;
                 default:
                    Console.WriteLine("Not Known");
                    break;
             }
             Console.WriteLine("Press Enter Key to Exit..");
             Console.ReadLine();
         }
     }
} 