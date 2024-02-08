using System;
using System.Linq;
using System.Collections.Generic;

namespace Linq{
	class Program{
		static void Main(string [] args){
			List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

			var evenNumbers = from num in numbers 
							  where num % 2 == 0
							  select num;

			//var evenNumbers = numbers.Where(num => num % 2 ==0);

			Console.WriteLine(string.Join(", ", evenNumbers));

			foreach(var num in evenNumbers){
				Console.WriteLine(num);
			}
		}
	}
}