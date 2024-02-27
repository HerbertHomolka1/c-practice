namespace TicTacToe 
{
    public class Menu
    {
        public int ShowMenu()
        {
            int choice;
            do
            {
                choice = ShowSingleMenuIteration();
            }
            while (!Utils.ValidateInput(choice,1,3));

            return choice;
    
        }

        public int ShowSingleMenuIteration()
        {
            int choice;
            Console.Write("1. Nowa Gra \r\n2. Zasady \r\n3. Zamknij Aplikację \r\n");
            choice = Utils.GetUserInputAsIntiger();
            if (!Utils.ValidateInput(choice,1,3))
            {
                Console.WriteLine("Wybierz 1, 2 albo 3");
            }
            return choice;
        }
    }
}