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
    public class TaskSix
    {
        public static void Main()
        {  
            int[] numbers = new int[3];

            string line;
            int number;
            for (int i = 0; i<3 ; i++)
            {
                line = Console.ReadLine();
                Int32.TryParse(line, out number);
                numbers[i] = number;
            }
            
            Array.Sort(numbers);

            Console.WriteLine(numbers[2]);
        }
    }
}