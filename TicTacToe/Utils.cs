namespace TicTacToe 
{
    public static class Utils
    {
        public static int GetUserInputAsIntiger()
        {
            string userResponse = Console.ReadLine();
            int intigerInput;
            Int32.TryParse(userResponse, out intigerInput);
            return intigerInput;
    
        }
        public static bool ValidateInput(int input, int minNum, int maxNum)
        {
            return input >= minNum && input <= maxNum;
        }
    }
}