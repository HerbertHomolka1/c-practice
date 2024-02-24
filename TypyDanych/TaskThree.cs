using System;

// Napisz program, który na podstawie podanej szerokości i długości prostokąta wyliczy długość
// przekątnej. (Aby, obliczyć kwadrat liczby użyj metody Math.Pow())

namespace DataTypes 
{
    class TaskThree
    {
        public static void Main()
        {
            string line = Console.ReadLine();
            int a;
            Int32.TryParse(line, out a);

            line = Console.ReadLine();
            int b;
            Int32.TryParse(line, out b);

            double diagonal = Math.Pow(a*b,0.5);
            Console.WriteLine(diagonal);
        }
    }
}