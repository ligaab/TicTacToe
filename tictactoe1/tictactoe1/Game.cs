﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe1
{
    public class Game
    {
        public static int step;

        public static string[] pos = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

       public static void Main(string[] args)
        {
            //DrawBoard();
            //Console.WriteLine("");
        }
            public static void DrawBoard()
        {
            Console.WriteLine(GetFirstLineTekst(pos));
            Console.WriteLine("-------------------");
            Console.WriteLine(GetSecondLineTekst(pos));
            Console.WriteLine("-------------------");
            Console.WriteLine(GetThirdLineTekst(pos));

            
        }
        public static string GetFirstLineTekst(string[] values)
        {
            string text = $"  {values[0]}  |  {values[1]}  |  {values[2]}  ";
            return text;
            
        }
        public static string GetSecondLineTekst(string[] values)
        {
            string text = $"  {values[0]}  |  {values[1]}  |  {values[2]}  ";
            return text;

        }
        public static string GetThirdLineTekst(string[] values)
        {
            string text = $"  {values[0]}  |  {values[1]}  |  {values[2]}  ";
            return text;

        }

        public static bool CheckWin()
        {
            if (pos[1] == "O" && pos[2] == "O" && pos[3] == "O" ||
                   pos[4] == "O" && pos[5] == "O" && pos[6] == "O" ||
                   pos[7] == "O" && pos[8] == "O" && pos[9] == "O" ||
                   pos[1] == "O" && pos[5] == "O" && pos[9] == "O" ||
                   pos[7] == "O" && pos[5] == "O" && pos[3] == "O" ||
                   pos[1] == "O" && pos[4] == "O" && pos[7] == "O" ||
                   pos[2] == "O" && pos[5] == "O" && pos[8] == "O" ||
                   pos[3] == "O" && pos[6] == "O" && pos[9] == "O" ||
                   pos[1] == "X" && pos[2] == "X" && pos[3] == "X" ||
                   pos[4] == "X" && pos[5] == "X" && pos[6] == "X" ||
                   pos[7] == "X" && pos[8] == "X" && pos[9] == "X" ||
                   pos[1] == "X" && pos[5] == "X" && pos[9] == "X" ||
                   pos[7] == "X" && pos[5] == "X" && pos[3] == "X" ||
                   pos[1] == "X" && pos[4] == "X" && pos[7] == "X" ||
                   pos[2] == "X" && pos[5] == "X" && pos[8] == "X" ||
                   pos[3] == "X" && pos[6] == "X" && pos[9] == "X")
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
