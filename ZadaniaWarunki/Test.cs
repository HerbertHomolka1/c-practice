using System;

namespace Tasks
{
    public class TaskTwelve
    {
        public static void Main()
        {  
           int day;
           string line = Console.ReadLine();
           Int32.TryParse(line, out day);
           int dayOfTheWeek;


           switch(day)
           {
            1: dayOfTheWeek = "Poniedziałek",
            2: dayOfTheWeek = "Wtorek",
            3: dayOfTheWeek = "Środa", 
            4: dayOfTheWeek = "Czwartek",
            5: dayOfTheWeek = "Piątek",
            6: dayOfTheWeek = "Sobota", 
            7: dayOfTheWeek = "Niedziela",
            default: dayOfTheWeek = "Tydzień ma 7 dni"
           }

           Console.WriteLine(dayOfTheWeek);

        }
    }
}
