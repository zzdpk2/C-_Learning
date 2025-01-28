using System;

namespace HelloWorld {
    class Program {
        static void Main(string[] args) {

            int number1 = 0;
            Console.WriteLine("number1: ", number1);

            Console.WriteLine("My name is {0}. I am {1} year old.", "Alex", 100);

            // Embedded String
            string name = "Alex";
            int age = 101;
            string message3 = $"My name is {name}. I am {age} year old.";
            Console.WriteLine(message3);

            Console.WriteLine(@"My name is {0}.\n
I am {1}



year old.\n", 
"Alex", 100);

            Console.Read();
        }
    }
}