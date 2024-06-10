using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[3]; //compiler knows numbers is assigned to an integer so use var to keep code clean
            numbers[0] = 1;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3]; //compiler knows numbers is assigned to an boolean so use var to keep code clean
            flags[0] = true;
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new string[3] {"Tae", "Tegan", "CT"};
            Console.WriteLine(names);
            //use curly braces to define array elements within same line


        }
    }
}
