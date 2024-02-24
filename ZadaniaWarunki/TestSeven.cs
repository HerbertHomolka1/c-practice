using System;

// Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi,
// która jest największa
// Dane testowe:
// 25
// 63
// 79
// Rezultat w terminalu :
// 79 jest największa z podanych

namespace Tasks
{
    public class TaskTwo
    {
        public static void Main()
        {  
            int a;
            string line = Console.ReadLine();
            Int32.TryParse(line, out a);
            bool AIsEven = a % 2 == 0;

            if (AIsEven)
            {
                Console.WriteLine($"{a} jest liczbą parzystą");
            } 
            else 
            {
                Console.WriteLine($"{a} jest liczbą nieparzystą");
            }
            
        }
    }
}