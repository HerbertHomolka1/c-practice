using System;

// Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba
// jest dodatnia czy ujemna.
// Dane testowe : 14
// Rezultat w terminalu :
// 14 jest liczbą dodatnią

namespace Tasks
{
    public class TaskThree
    {
        public static void Main()
        {  
           int a;
           string line = Console.ReadLine();
           Int32.TryParse(line, out a);

           if (a > 0)
           {
            Console.WriteLine($"{a} jest liczbą dodatnią");
           } 
           else if (a < 0)
           {
            Console.WriteLine($"{a} jest liczbą ujemną");
           }
           else
           {
            Console.WriteLine($"{a} nie jest ani dodatnie ani ujemne");
           }
        }
    }
}