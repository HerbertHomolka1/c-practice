using System;

// Napisz program w C#, który sprawdzi czy podany przez użytkownika rok
// jest rokiem przestępnym.
// Dane testowe : 2016
// Rezultat w terminalu :
// 2016 jest rokiem przestępnym

namespace Tasks
{
    public class TaskFour
    {
        public static void Main()
        {  
            int year;
            string line = Console.ReadLine();
            Int32.TryParse(line, out year);
            bool IsALeapYear = year % 4 == 0;

            if (IsALeapYear) 
            {
                Console.WriteLine($"{year} jest rokiem przestępnym");
            }
            else
            {
                Console.WriteLine($"{year} nie jest rokiem przestępnym");
            }
        }
    }
}