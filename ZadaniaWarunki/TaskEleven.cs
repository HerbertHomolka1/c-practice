using System;

// Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli
// Dane testowe : 3
// Rezultat w terminalu :
// Dostateczny

namespace Tasks
{
    public class TaskEleven
    {
        public static void Main()
        {  
            int grade;
            string output = "";
            string line = Console.ReadLine();
            Int32.TryParse(line, out grade);

            switch(grade)
            {
                case 6:
                    output = "Celujący";
                    break;
                case 5:
                    output = "Bardzo Dobry";
                    break;
                case 4:
                    output = "Dobry";
                    break;
                case 3:
                    output = "Dostateczny";
                    break;
                case 2:
                    output = "Dopuszczający";
                    break;
                case 1:
                    output = "Niedostateczny";
                    break;
                default:
                    output = "Podaj liczbę od 1 do 6";
                    break;
            }

            Console.WriteLine(output);
        }
    }
}