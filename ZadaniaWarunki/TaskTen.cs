using System;

// Napisz program, który sprawdzi, czy z 3 podanych długości można
// stworzyć trójkąt
// Dane testowe : 40 55 65
// Rezultat w terminalu :
// Można zbudować trójkąt

namespace Tasks
{
    public class TaskTen
    {
        public static void Main()
        {  
            int a;
            string line = Console.ReadLine();
            Int32.TryParse(line, out a);

            int b;
            line = Console.ReadLine();
            Int32.TryParse(line, out b);

            int c;
            line = Console.ReadLine();
            Int32.TryParse(line, out c);

            Console.WriteLine($"{a} {b} {c}");

            bool cond1 = a < b + c;
            bool cond2 = b < a + c;
            bool cond3 = c < a + b;

            if (cond1&&cond2&&cond3)
            {
                Console.WriteLine("Można zbudować trójkąt");
            }
            else
            {
                Console.WriteLine("Nie można zbudować trójkąta");
            }
        }
    }
}