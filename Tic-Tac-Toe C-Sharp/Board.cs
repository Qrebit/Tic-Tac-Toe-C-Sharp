using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_C_Sharp
{
    class Board:Сhecker
	{
        public int[] board = new int[9] { 0,0,0,0,0,0,0,0,0 };

		public string You;
		public string Enemy;

		public void Clear(int[] board)
        {
			for(int i = 0; i < 9; i++)
            {
				board[i] = 0;
            }
		}
		public void Drawer(int[] board, string You, string Enemy)
		{
			Console.Clear();
			int counter = 0;
			Console.Write("\t\t\t\t\t\t");
			Console.Write("╔");
			for (int i = 0; i < 9; i++)
			{
				Console.Write("═");
			}
			Console.WriteLine("╗");
			Console.Write("\t\t\t\t\t\t");
			Console.Write("║");
			for (int i = 0; i < 9; i++)
			{
				if (board[i] == 1)
				{
					Console.Write(Enemy);
				}
				else
				{
					if (board[i] == 2)
					{
						Console.Write(You);
					}
					else
					{
						Console.Write($" {counter+1} ");
					}
				}
				counter++;
				if (counter == 3 || counter == 6) {
					Console.Write("║");
					Console.WriteLine("\t\t\t\t\t\t");
					Console.Write("\t\t\t\t\t\t");
					Console.Write("║");
				}
			if (counter == 9)
			{
					Console.WriteLine("║");
				}
		}
			Console.Write("\t\t\t\t\t\t");
			Console.Write("╚");
			for (int i = 0; i< 9; i++) {
				Console.Write("═");
			}
			Console.WriteLine("╝");
		}
    }
}
