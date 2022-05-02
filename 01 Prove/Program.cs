/*
Tic-Tac-Toe
Rony Richard
*/
    class Program
    {

        static char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int selection;
        static int winner = 0;
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Player 1 is X and Player 2 is O");
                Console.WriteLine("\n");
                Board();
                selection = int.Parse(Console.ReadLine());
                if (numbers[selection] != 'X' && numbers[selection] != 'O')
                {
                    if (player % 2 == 0)
                    {
                        numbers[selection] = 'O';
                        player++;
                    }
                    else
                    {
                        numbers[selection] = 'X';
                        player++;
                    }
                }

                winner = has_winner();
            }
            while (winner != 1 && winner != -1);
            Console.Clear();
            Board();
            if (winner == 1)
            {
                Console.WriteLine("Player {0} Wins!", (player % 2) + 1);
            }
            else
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
        }
        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", numbers[1], numbers[2], numbers[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", numbers[4], numbers[5], numbers[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", numbers[7], numbers[8], numbers[9]);
            Console.WriteLine("     |     |      ");
        }
        //Checking that any player has won or not
        private static int has_winner()
        {
            //First Row Win
            if (numbers[1] == numbers[2] && numbers[2] == numbers[3])
            {
                return 1;
            }
            //Second Row Win
            else if (numbers[4] == numbers[5] && numbers[5] == numbers[6])
            {
                return 1;
            }
            //Third Row Win
            else if (numbers[6] == numbers[7] && numbers[7] == numbers[8])
            {
                return 1;
            }
            //First Column Win
            else if (numbers[1] == numbers[4] && numbers[4] == numbers[7])
            {
                return 1;
            }
            //Second Column Win
            else if (numbers[2] == numbers[5] && numbers[5] == numbers[8])
            {
                return 1;
            }
            //Third Column Win
            else if (numbers[3] == numbers[6] && numbers[6] == numbers[9])
            {
                return 1;
            }
            else if (numbers[1] == numbers[5] && numbers[5] == numbers[9])
            {
                return 1;
            }
            else if (numbers[3] == numbers[5] && numbers[5] == numbers[7])
            {
                return 1;
            }
            // If all the cells or values filled with X or O then any player has won the match
            else if (numbers[1] != '1' && numbers[2] != '2' && numbers[3] != '3' && numbers[4] != '4' && numbers[5] != '5' && numbers[6] != '6' && numbers[7] != '7' && numbers[8] != '8' && numbers[9] != '9')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
