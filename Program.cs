using System;


namespace Chapter1
{ 
    class FirstProgram
    {
        static void Main(string[] args)
        {
            //Variable and Types
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


            // Type Cast
            byte age2 = 24;
            int in10Years = age2 + 10;
            byte in10YearsByte = (byte)(age2 + 10);
            Console.WriteLine(in10Years);
            Console.WriteLine(in10YearsByte);

            //For Loop
            int[] points = new int[] { 1, 2, 3, 4, 5, 6 };
            int sum = 0;
            for (int i = 0; i < points.Length; i++)
            {
                sum += points[i];
            }

            Console.WriteLine($"The total sum is {sum}");
            int sum2 = 0;
            foreach (int point in points)
            {
                sum2 += point;
            }

            Console.WriteLine($"The total sum2 is {sum2}");

            DayOfWeek currentDay = DayOfWeek.Thursday;
            PrintMessageOfTheDay(currentDay);
        }

        // Here our method accepts an enum type as a parameter
        static void PrintMessageOfTheDay(DayOfWeek day)
        {
            // Performing different operations based on the value of the enum variable
            switch (day)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Brace yourself. The week only started.");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("Still many days to go...");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Halfway through. Great!");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Just one more day left!");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Ohooo! Party tonight!");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Time to enjoy the weekend.");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("The last day...");
                    break;
            }
        }
    }
}