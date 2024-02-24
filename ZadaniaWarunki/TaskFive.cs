using System;

// Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek
// uprawnia go do ubiegania się o stanowisko posła, premiera, sentarora,
// prezydenta.
// Dane testowe : 21
// Rezultat w terminalu :
// Możesz zostać posłem

namespace Tasks
{
    public class TaskFive
    {
        public static void Main()
        {  
          int age;
          string line = Console.ReadLine();
          Int32.TryParse(line, out age);

          string output;
          if (age>=35)
          {
            output = "Możesz zostać Prezydentem";
          }
          else if (age >= 25 )
          {
            output = "Możesz zostać Burmistrzem";
          }
          else if (age >= 21)
          {
            output = "Możesz zostać posłem";
          }
          else 
          {
            output = "Jesteś zbyt młody i nie masz biernych praw wyborczych...";
          }

          Console.WriteLine(output);
        }
    }
}