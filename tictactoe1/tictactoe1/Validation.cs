using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe1
{
    public class Validation
    {
        

        public static void NotRightNumber(int step)
        {


            if (step < 0 || step > 10)
            {
                throw new NotRightNumber("neatbilstos cipars");

            }
          


                

        }
        public static void CorectInput(string[] pos)
        {

            if (pos[1] == "O" || pos[2] == "O" || pos[3] == "O" || pos[4] == "O" || pos[5] == "O" || pos[6] == "O" ||pos[7] == "O" || pos[8] == "O" || pos[9] == "O")
            {
                throw new CorectInput("Sis laucins ir aiznemts, ludzu izvelies citu");
            }
           

        }

    }
}
