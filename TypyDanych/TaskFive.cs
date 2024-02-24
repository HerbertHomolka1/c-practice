using System;

// Napisz program w którym poprosisz użytkownika o jego dane personalne tj. Imię, nazwisko,
// numer telefonu, adres email, wzrost, waga (np. 85,7), itp (postaraj się wymyślić jak najwięcej)
// i spróbuj przekonwertować odpowiedź do odpowiedniego typu danych używając metody:
// typDanych.Parse(odpowiedźOdUżytkownika).

namespace DataTypes 
{
    class TaskFive
    {
        public static void Main()
        {
            string line;

            Console.WriteLine("Podaj swoje imię");
            string name = Console.ReadLine();

            Console.WriteLine("Podaj swoje nazwisko");
            string surname = Console.ReadLine();
            
            Console.WriteLine("Podaj swój wiek");
            line = Console.ReadLine();
            int age;
            Int32.TryParse(line, out age);

            string sex = Console.ReadLine();

            Console.WriteLine("Podaj swój wiek");
            line = Console.ReadLine();
            double pesel;
            Double.TryParse(line, out pesel);

            Console.WriteLine("Podaj swój wiek");
            line = Console.ReadLine();
            double employeeNumber;
            Double.TryParse(line, out employeeNumber);

        }
    }
}