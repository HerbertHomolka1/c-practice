using System;

// Napisz program, który pobierze numer dnia tygodnia i wyświetli jego
// nazwę
// Dane testowe : 4
// Rezultat w terminalu :
// Czwartek

namespace Tasks
{
    public class TestTwelve
    {
        public static void Main()
        {
            string userResponse = Console.ReadLine();
            int day;
            Int32.TryParse(userResponse,out day);
            string dayName = day switch 
            {
                1 =>  "Poniedziałek",
                2 =>  "Wtorek",
                3 =>  "Środa", 
                4 =>  "Czwartek",
                5 =>  "Piątek",
                6 =>  "Sobota", 
                7 =>  "Niedziela",
                _ =>  "Tydzień ma 7 dni"
            };

            Console.WriteLine(dayName);
        }
    }
}
