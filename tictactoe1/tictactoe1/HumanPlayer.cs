using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe1
{
    public class HumanPlayer : Player
    {
        public void GetPlayerName()
        {
            Console.WriteLine("Ievadiet savu vardu");
            Name = Console.ReadLine(); 
        }
    }
}
