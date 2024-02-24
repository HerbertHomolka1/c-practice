using System;

//  Napisz program, który odczyta temperaturę I zwróci nazwę jak w
// poniższych kryteriach
// Temp < 0 – cholernie piździ
// Temp 0 – 10 – zimno
// Temp 10 – 20 – chłodno
// Temp 20 – 30 – w sam raz
// Temp 30 – 40 – zaczyna być słabo, bo gorąco
// Temp >= 40 – a weź wyprowadzam się na Alaskę.
// Dane testowe : 41
// Rezultat w terminalu :
// a weź wyprowadzam się na Alaskę.

namespace Tasks
{
    public class TaskNine
    {
        public static void Main()
        {  
            int temperature;
            string line = Console.ReadLine();
            Int32.TryParse(line, out temperature);
            
            if (temperature<0)
            {
                Console.WriteLine("cholernie piździ");
            }
            else if (temperature<10)
            {
                Console.WriteLine("zimno");
            }
            else if (temperature<20)
            {
                Console.WriteLine("chłodno");
            }
            else if (temperature<30)
            {
                Console.WriteLine("w sam raz");
            }
            else if (temperature<40)
            {
                Console.WriteLine("zaczyna być słabo, bo gorąco");
            }
            else
            {
                Console.WriteLine("a weź wyprowadzam się na Alaskę.");
            }
        }
    }
}