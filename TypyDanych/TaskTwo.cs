using System;

// Napisz program, w którym stworzysz 3 zmienne z jedną literą, a następnie wypiszesz je w
// odwrotnej kolejności niż zostały zadeklarowane.

namespace DataTypes 
{
    class TaskTwo
    {
        public static void Main()
        {
            char a = 'a';
            char b = 'b';
            char c = 'c';

            Console.WriteLine($"c: {c} b: {b} a: {a}");

        }
    }
}