namespace TicTacToe 
{
    public class Program
    {
        public static void Main()
        {
            bool programIsRunning = true;
            int choice;
            while (programIsRunning)
            {
                // Pokaż menu startowe graczowi, i otrzymaj informację o tym co che zrobić
                Menu menu = new Menu();
                choice = menu.ShowMenu();

                // Na podstawie tego co gracz chce zrobić 1. rozpocznij grę 2. Wypisz zasady gry 3. zamknij program
                switch (choice)
                {
                    case 1:
                        Game game = new Game();
                        game.StartGame();
                        break;
                    case 2:
                        Console.WriteLine("Na poszczególnych polach wyznaczonych przez tę figurę (gdyby wpisać ją w kwadrat, pojedynczym polem byłby kwadrat o krawędzi 1/3 kwadratu opisanego) gracze stawiają na przemian kółko i krzyżyk. Gdy któryś z graczy stworzy linię trzech krzyżyków lub trzech kółek, przekreśla ją i zostaje zwycięzcą.");
                        break;
                    case 3:
                        programIsRunning = false;
                        break;
                }
            }         
        }
    }
}

