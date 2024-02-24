using System;

// Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są
// one równe czy nie.
// Dane testowe:
// a : 5
// b : 5
// Rezultat w terminalu :
// 5 i 5 są równe

namespace Tasks
{
    public class TaskOne
    {
        public static void Main()
        {  
            int a;
            int b;

            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();

            Int32.TryParse(line1, out a);
            Int32.TryParse(line2, out b);

            bool AEqualsB = a == b;

            if (AEqualsB)
            {
                Console.WriteLine($"{a} i {b} są równe");
            }
            else
            {
                Console.WriteLine($"{a} i {b} nie są równe");
            }
        }
    }
}