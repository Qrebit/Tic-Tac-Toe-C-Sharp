using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_C_Sharp
{
	//Изменяю
    class Program
    {
		static void Main(string[] args)
		{
			Random rnd = new Random();
			Board Board = new Board();
			string Cycle = "1";
			while (Cycle == "1")
			{
				Board.win = 0;
				Board.choice = 0;
				Board.turn = 0;
				Board.Clear(Board.board);
				Console.WriteLine("Choose symbol:");
				Console.WriteLine("1 - X");
				Console.WriteLine("2 - O");
				Board.You = Console.ReadLine();
				if (Board.You == "1")
				{
					Board.You = " X ";
					Board.Enemy = " O ";
				}
				else
				{
					Board.You = " O ";
					Board.Enemy = " X ";
				}
				while (Board.win == 0)
				{
					Console.Clear();
					Board.Drawer(Board.board,Board.You,Board.Enemy);
					Console.WriteLine();
					if (Board.turn == 0) Board.turn += rnd.Next() % 2;
					if (Board.turn % 2 == 0)
					{
						Console.WriteLine("\t\t\t\t\t\t Player Turn");
						Console.WriteLine("\t\t\t\t\t Choose place of the symbol:");
						Board.choice = Convert.ToInt32(Console.ReadLine());
						Board.board[Board.choice - 1] =  2;
						Board.turn++;
					}
					else
					{
						Board.choice = Board.AI(Board.board);
						Board.board[Board.choice] = 1;
						Board.turn++;
					}
					Board.win = Board.Check(Board.board);
				}
				Console.Clear();
				Board.Drawer(Board.board, Board.You, Board.Enemy);
				if (Board.win == 2)
				{
					Console.WriteLine("\n\n\t\t\t\t\t\tPlayer Wins \n\n");
				}
				else if (Board.win == 1)
				{
					Console.WriteLine("\n\n\t\t\t\t\t\tComputer Wins \n\n");
				}
				else if (Board.win == 3)
				{
					Console.WriteLine("\n\n\t\t\t\t\t\tDraw \n");
				}
				Console.WriteLine("Another game?");
				Console.WriteLine("1 - Yes");
				Console.WriteLine("2 - No");
				Cycle = Console.ReadLine();
				Console.Clear();
			}
		}
    }
}
