using System;

//  Napisz program, który będzie posiadał proste menu (wg. Wzoru poniżej) I
// będzie prostym kalkulatorem
// Podaj pierwszą liczbę:
// …
// Podaj drugą liczbę:
// …
// Podaj numer operacji do wykonania:
// 1. Dodawanie
// 2. Odejmowanie
// 3. Mnożenie
// 4. Dzielenie
// …
// Twój wynik to:

namespace Tasks
{
    public class TaskThirteen
    {
        public static void Main()
        {  
        
        int firstNum;
        Console.WriteLine("Podaj pierwszą liczbę:");
        string userResponse = Console.ReadLine();
        Int32.TryParse(userResponse, out firstNum);

        int secondNum;
        Console.WriteLine("Podaj drugą liczbę:");
        userResponse = Console.ReadLine();
        Int32.TryParse(userResponse, out secondNum);

        Console.Write("Podaj numer operacji do wykonania:\r\n1. Dodawanie\r\n2. Odejmowanie\r\n3. Mnożenie\r\n4. Dzielenie\r\n");
        userResponse = Console.ReadLine();
        int operation;
        Int32.TryParse(userResponse,out operation);
        switch(operation)
        {
            //dodawanie
            case 1:
                Console.WriteLine(firstNum+secondNum);
                break;
            //odejmowanie
            case 2:
                Console.WriteLine(firstNum-secondNum);
                break;
            //mnożenie
            case 3:
                Console.WriteLine(firstNum*secondNum);
                break;
            //dzielenie
            case 4:
                Console.WriteLine(firstNum/secondNum);
                break;
            default:
                Console.WriteLine("podaj liczbę od 1 do 4");
                break;
        }
        }
    }
}