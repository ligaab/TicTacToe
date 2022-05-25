using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe1
{
    public class Game
    {
        public static string[] pos = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

       public static void Main(string[] args)
        {
            //DrawBoard();
            //Console.WriteLine("");
        }
            public static void DrawBoard()
        {
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[1], pos[2], pos[3]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[4], pos[5], pos[6]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[7], pos[8], pos[9]);

            
        }

           
        
    }
}
