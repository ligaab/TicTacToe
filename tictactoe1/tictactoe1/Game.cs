using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe1
{
    public class Game
    {
        public static int Player;
        public static int step1 = 1;
        public static int step2 = 2;
        public static int flag = 0;
        public static string input;
        public static int board = -1;
        public static int choice;
        public static string step;
        public static string[] pos = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        private object notRighteNumber;
        private object corectInput;


        public static void Main(string[] args)
        {
            DrawBoard();
            Console.WriteLine("");
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
            string text = $"  {values[1]}  |  {values[2]}  |  {values[3]}  ";
            return text;
        }
        public static string GetSecondLineTekst(string[] values)
        {
            string text = $"  {values[4]}  |  {values[5]}  |  {values[6]}  ";
            return text;
        }
        public static string GetThirdLineTekst(string[] values)
        {
            string text = $"  {values[7]}  |  {values[8]}  |  {values[9]}  ";
            return text;
        }
        //public static bool correctInput()
        //{
        //    if (pos[step2] == "X" || pos[step1] == "O")
        //    {
        //        //Console.WriteLine("false");
        //        return false;
        //    }
        //   else
        //    {
        //        //Console.WriteLine("true");
        //        return true;
        //    }
        //}
        public static int CheckWin()
        {
            if
                (pos[1] == "X" && pos[2] == "X" && pos[3] == "X" ||
                  pos[4] == "X" && pos[5] == "X" && pos[6] == "X" ||
                  pos[7] == "X" && pos[8] == "X" && pos[9] == "X" ||
                  pos[1] == "X" && pos[5] == "X" && pos[9] == "X" ||
                  pos[3] == "X" && pos[5] == "X" && pos[7] == "X" ||
                  pos[1] == "X" && pos[4] == "X" && pos[7] == "X" ||
                  pos[2] == "X" && pos[5] == "X" && pos[8] == "X" ||
                  pos[3] == "X" && pos[6] == "X" && pos[9] == "X")
            {
                //Console.WriteLine("1");
                return 1;
            }

            if
               (pos[1] == "O" && pos[2] == "O" && pos[3] == "O" ||
                  pos[4] == "O" && pos[5] == "O" && pos[6] == "O" ||
                  pos[7] == "O" && pos[8] == "O" && pos[9] == "O" ||
                  pos[1] == "O" && pos[5] == "O" && pos[9] == "O" ||
                  pos[3] == "O" && pos[5] == "O" && pos[7] == "O" ||
                  pos[1] == "O" && pos[4] == "O" && pos[7] == "O" ||
                  pos[2] == "O" && pos[5] == "O" && pos[8] == "O" ||
                  pos[3] == "O" && pos[6] == "O" && pos[9] == "O")
            {
                //Console.WriteLine("2");
                return 2;
            }
            else
            {
                //Console.WriteLine("0");
                return 0;
            }
        }
        public static int boardFull()
        {
            if (pos[1] != "1" && pos[2] != "2" && pos[3] != "3" && pos[4] != "4" && pos[5] != "5" && pos[6] != "6" && pos[7] != "7" && pos[8] != "8" && pos[9] != "9")
            {
                //Console.WriteLine("-1");
                return -1;
            }
            else
            {
                return 0;
            }
        }
        public static void choiceGameover()
        {
            if (flag == 1 || flag == 2 || board == -1)
            {
                Console.WriteLine("Ko darīsim tālāk?");
                Console.WriteLine("1. Spēlēt atkal");
                Console.WriteLine("2. Pamest spēli");
                Console.WriteLine("");
                Console.WriteLine("Ievadi savu izvēli: ");
                choice = int.Parse(Console.ReadLine());

                for (int i = 1; i < 10; i++)
                {
                    pos[i] = i.ToString();
                }
                if (choice == 1)
                {
                    Console.Clear();
                    Console.WriteLine();
                    DrawBoard();
                    Console.WriteLine("Spēlējam atkal!");
                }
                else if (choice == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Paldies par Spēli!");
                }
            }
        }
       
    }

     
}





    

