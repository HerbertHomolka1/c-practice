using System;

// Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba
// jest parzysta czy nieparzysta.
// Dane testowe : 15
// Rezultat w terminalu :
// 15 jest liczbą nieparzystą

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