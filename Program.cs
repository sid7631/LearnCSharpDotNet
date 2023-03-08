using System;

namespace FirstProgram
{
    class VariableDataTypes
    {
        static void Main(string[] args)
        {
            int age = 10;
            string name = "Student123";
            Console.WriteLine($"Student {name} has age {age}");

            //Array
            string[] student1 = new string[10];
            string[] student2 = new string[3] { "StudentA", "StudentB", "StudentC" };
            string[] student3 = new string[] { "StudentA", "StudentB", "StudentC" };
            string[] student4 = new[] { "StudentA", "StudentB", "StudentC" };
            string[] student5 = { "StudentA", "StudentB", "StudentC" };
            Console.WriteLine($"Array 1 length is {student1.Length}");
            Console.WriteLine($"Array 2 length is {student2.Length}");
            Console.WriteLine($"Array 3 length is {student3.Length}");
            Console.WriteLine($"Array 4 length is {student4.Length}");
            Console.WriteLine($"Array 5 length is {student5.Length}");

            // Type example
            System.Int32 firstNumber = 30;
            int secondNumer = 30;
            Console.WriteLine($"firstNumber is of type {firstNumber.GetType()}");
            Console.WriteLine($"secondNumber is of type {secondNumer.GetType()}");

        }
    }
}
