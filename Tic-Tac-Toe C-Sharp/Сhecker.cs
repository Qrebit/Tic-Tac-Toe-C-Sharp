using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_C_Sharp
{
	public class Сhecker
	{
		public int win;
		public int choice;
		public int turn;

		public static int AI(int[] board)
		{
			int temp = 0;
			bool check = false;

			if (board[0] == 1)
			{
				if (board[1] == 1 && board[2] == 0) {
					return 2;
				}
				if (board[2] == 1 && board[1] == 0) {
					return 1;
				}
				if (board[4] == 1 && board[8] == 0) {
					return 8;
				}
				if (board[8] == 1 && board[4] == 0) {
					return 4;
				}
				if (board[3] == 1 && board[6] == 0) {
					return 6;
				}
				if (board[6] == 1 && board[3] == 0) {
					return 3;
				}
			}
			if (board[1] == 1)
			{
				if (board[2] == 1 && board[0] == 0) {
					return 0;
				}
		else if (board[4] == 1 && board[7] == 0) {
					return 7;
				}
		else if (board[7] == 1 && board[4] == 0) {
					return 4;
				}
			}
			if (board[2] == 1)
			{
				if (board[4] == 1 && board[6] == 0) {
					return 6;
				}
		else if (board[6] == 1 && board[4] == 0) {
					return 4;
				}
		else if (board[5] == 1 && board[5] == 0) {
					return 8;
				}
		else if (board[8] == 1 && board[8] == 0) {
					return 5;
				}
			}
			if (board[3] == 1)
			{
				if (board[6] == 1 && board[0] == 0) {
					return 0;
				}
		else if (board[4] == 1 && board[5] == 0) {
					return 5;
				}
		else if (board[5] == 1 && board[4] == 0) {
					return 4;
				}
			}
			if (board[4] == 1)
			{
				if (board[5] == 1 && board[3] == 0) {
					return 3;
				}
		else if (board[6] == 1 && board[2] == 0) {
					return 2;
				}
		else if (board[7] == 1 && board[1] == 0) {
					return 1;
				}
		else if (board[8] == 1 && board[0] == 0) {
					return 0;
				}
			}
			if (board[5] == 1)
			{
				if (board[3] == 1 && board[4] == 0) {
					return 4;
				}
		else if (board[8] == 1 && board[2] == 0) {
					return 2;
				}
			}
			if (board[6] == 1)
			{
				if (board[7] == 1 && board[8] == 0) {
					return 8;
				}
		else if (board[8] == 1 && board[7] == 0) {
					return 7;
				}
			}
			if (board[7] == 1 && board[6] == 0) {
				return 6;
			}

			if (board[0] == 2)
			{
				if (board[1] == 2 && board[2] == 0) {
					return 2;
				}
				if (board[2] == 2 && board[1] == 0) {
					return 1;
				}
				if (board[4] == 2 && board[8] == 0) {
					return 8;
				}
				if (board[8] == 2 && board[4] == 0) {
					return 4;
				}
				if (board[3] == 2 && board[6] == 0) {
					return 6;
				}
				if (board[6] == 2 && board[3] == 0) {
					return 3;
				}
			}
			if (board[1] == 2)
			{
				if (board[2] == 2 && board[0] == 0) {
					return 0;
				}
			else if (board[4] == 2 && board[7] == 0) {
					return 7;
				}
			else if (board[7] == 2 && board[4] == 0) {
					return 4;
				}
			}
			if (board[2] == 2)
			{
				if (board[4] == 2 && board[6] == 0) {
					return 6;
				}
				else if (board[6] == 2 && board[4] == 0) {
					return 4;
				}
				else if (board[5] == 2 && board[5] == 0) {
					return 8;
				}
				else if (board[8] == 2 && board[8] == 0) {
					return 5;
				}
			}
			if (board[3] == 2)
			{
				if (board[6] == 2 && board[0] == 0) {
					return 0;
				}
					else if (board[4] == 2 && board[5] == 0) {
					return 5;
				}
					else if (board[5] == 2 && board[4] == 0) {
					return 4;
				}
			}
			if (board[4] == 2)
			{
				if (board[5] == 2 && board[3] == 0) {
					return 3;
				}
						else if (board[6] == 2 && board[2] == 0) {
					return 2;
				}
						else if (board[7] == 2 && board[1] == 0) {
					return 1;
				}
						else if (board[8] == 2 && board[0] == 0) {
					return 0;
				}
			}
			if (board[5] == 2)
			{
				if (board[3] == 2 && board[4] == 0) {
					return 4;
				}
							else if (board[8] == 2 && board[2] == 0) {
					return 2;
				}
			}
			if (board[6] == 2)
			{
				if (board[7] == 2 && board[8] == 0) {
					return 8;
				}
								else if (board[8] == 2 && board[7] == 0) {
					return 7;
				}
			}
			if (board[7] == 2 && board[6] == 0) {
				return 6;
			}

			if (board[4] == 2)
			{
				if (board[0] == 1 && board[8] == 0) return 8;
				if (board[8] == 1 && board[0] == 0) return 0;
				if (board[2] == 1 && board[6] == 0) return 6;
				if (board[6] == 1 && board[8] == 0) return 2;
			}
			Random rnd = new Random();
			while (check == false)
			{
				temp = rnd.Next() % 9 + 1;
				if (board[temp] == 0)
				{
					check = true;
				}
			}
			return temp;
		}

		public static int Check(int[] board)
		{
			if (board[0] == 2 && board[1] == 2 && board[2] == 2) {
				return 2;
			}
	else if (board[3] == 2 && board[4] == 2 && board[5] == 2) {
				return 2;
			}
	else if (board[6] == 2 && board[7] == 2 && board[8] == 2) {
				return 2;
			}
	else if (board[0] == 2 && board[3] == 2 && board[6] == 2) {
				return 2;
			}
	else if (board[1] == 2 && board[4] == 2 && board[7] == 2) {
				return 2;
			}
	else if (board[2] == 2 && board[5] == 2 && board[8] == 2) {
				return 2;
			}
	else if (board[0] == 2 && board[4] == 2 && board[8] == 2) {
				return 2;
			}
	else if (board[2] == 2 && board[4] == 2 && board[6] == 2) {
				return 2;
			}

	else if (board[0] == 1 && board[1] == 1 && board[2] == 1) {
				return 1;
			}
	else if (board[3] == 1 && board[4] == 1 && board[5] == 1) {
				return 1;
			}
	else if (board[6] == 1 && board[7] == 1 && board[8] == 1) {
				return 1;
			}
	else if (board[0] == 1 && board[3] == 1 && board[6] == 1) {
				return 1;
			}
	else if (board[1] == 1 && board[4] == 1 && board[7] == 1) {
				return 1;
			}
	else if (board[2] == 1 && board[5] == 1 && board[8] == 1) {
				return 1;
			}
	else if (board[0] == 1 && board[4] == 1 && board[8] == 1) {
				return 1;
			}
	else if (board[2] == 1 && board[4] == 1 && board[6] == 1) {
				return 1;
			}
	else if (board[0] != 0 && board[1] != 0 && board[2] != 0 && board[3] != 0 && board[4] != 0 && board[5] != 0 && board[6] != 0 && board[7] != 0 && board[8] != 0) return 3;
	else return 0;
		}
	}
}
