using System;

// Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce
// na studiach wg. Następujących kryteriów:
// Wynik z Matury z matematyki powyżej 70
// Wynik z fizyki powyżej 55
// Wynik z chemii powyżej 45
// Łączny wynik z 3 przedmiotów powyżej 180
// Albo
// Wynik z matematyki i jednego przedmiotu powyżej 150
// Dane testowe:
// Matematyka 80
// Fizyka 71
// Chemia 0
// Rezultat w terminalu :
// Kandydat dopuszczony do rekrutacji

namespace Tasks
{
    public class TaskEight
    {
        public static void Main()
        {  
            int mathScore;
            string line = Console.ReadLine();
            Int32.TryParse(line, out mathScore);
            
            int physScore;
            line = Console.ReadLine();
            Int32.TryParse(line, out physScore);
            
            int chemScore;
            line = Console.ReadLine();
            Int32.TryParse(line, out chemScore);

            bool cond1 = chemScore>45 && physScore > 55 && mathScore > 70 && chemScore + physScore + mathScore > 180;
            bool cond2 = mathScore + physScore > 150 || mathScore + chemScore >150;
            if (cond1 || cond2 )
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else
            {
                Console.WriteLine("Kandydat nie dopuszczony do rekrutacji");
            }

        }
    }
}