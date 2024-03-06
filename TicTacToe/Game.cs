// użyte dla linii 120: return winCon.Any(x => x == true); 
using System.Linq;

namespace TicTacToe 
{
    public class Game
    {   
        public char[,] boardState = {{'.','.','.'},{'.','.','.'},{'.','.','.'}};

        public void StartGame()
        {
         int turn = 1;
         char symbol = 'X';
         while (!CheckForVictors(symbol)&&!CheckIfBoardFull())
         {
            if (turn % 2 == 0)
            {
               Console.WriteLine("Tura Krzyrzyka");
               symbol = 'X';
            } 
            else 
            {
               Console.WriteLine("Tura Kółka");
               symbol = 'O';
            }

            ShowBoard();
            int row, column;
            GetRowAndColumnFromUser(out row, out column);
            UpdateBoard(row, column, symbol);
            turn ++;
         }
         ShowBoard();

         if (CheckForVictors(symbol))
         {
            Console.WriteLine($"Gratulacje! {symbol} wygrał!!!");
         }
         else
         {
            Console.WriteLine("Remis.");
         }
         
         
        }
        public void GetRowAndColumnFromUser(out int row, out int column)
        {
            do
            {
               Console.WriteLine("Podaj rząd");
               row = Utils.GetUserInputAsIntiger();
               Console.WriteLine("Podaj columnę");
               column = Utils.GetUserInputAsIntiger();
               row --;
               column --;
               if (!Utils.ValidateInput(row,0,2)||!Utils.ValidateInput(column,0,2))
               {
                  Console.WriteLine("Wybierz liczbę od 1 do 3");
               }
               else if (!CheckIfFieldIsAvailable(row,column))
               {
                  Console.WriteLine("To pole jest już zajęte...");
               }

            }
            while (!CheckIfFieldIsAvailable(row,column) ||!Utils.ValidateInput(row,0,2)||!Utils.ValidateInput(column,0,2));


            Console.WriteLine($"{row} {column}");
        }

        public void ShowBoard()
        {
            string boardStateAsString = "";
            
            for (int i = 0; i < boardState.GetLength(0) ; i++)
            {
               for (int j = 0; j < boardState.GetLength(1) ; j++)
               {
                  boardStateAsString += boardState[i,j];
               }    
               boardStateAsString += "\r\n";
            }
         
           Console.Write(boardStateAsString);
        }
        public void UpdateBoard(int row, int column, char symbol)
        {

            boardState[row,column] = symbol;
        }
        public bool CheckIfFieldIsAvailable(int row, int column)
        {
            if (Utils.ValidateInput(row,0,2) && Utils.ValidateInput(column,0,2))
            {
               return boardState[row,column] != 'O' && boardState[row,column] != 'X';
            }
            else 
            {
               return false;
            }
            
        }
          

        public bool CheckForVictors(char symbol)
        {
           List<bool> winCon = new List<bool>();
           winCon.Add(boardState[0,0] == symbol && boardState[1,1] == symbol && boardState[2,2] == symbol);
           winCon.Add(boardState[2,0] == symbol && boardState[1,1] == symbol && boardState[0,2] == symbol);
           
           for (int i = 0; i < 3; i++)
           {
             winCon.Add(boardState[i,0] == symbol && boardState[i,1] == symbol && boardState[i,2] == symbol);
             winCon.Add(boardState[0,i] == symbol && boardState[1,i] == symbol && boardState[2,i] == symbol);
           }

           return winCon.Any(x => x == true);
        }

        public bool CheckIfBoardFull() 
        {
         for (int i = 0; i < boardState.GetLength(0) ; i++)
            {
               for (int j = 0; j < boardState.GetLength(1) ; j++)
               {
                  if (!(boardState[i,j] == 'X' || boardState[i,j] == 'O'))
                  {
                     return false;
                  }  
               }    
               
            }
            return true;

    }
}
}