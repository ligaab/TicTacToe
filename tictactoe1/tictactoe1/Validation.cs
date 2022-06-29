using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tictactoe1
{
    public class Validation
    {
       public static int step2;
        public static int step1;

        public static void NotRightNumber(int step)
        {


            if (step < 0 || step > 10)
            {
                throw new NotRightNumber("neatbilstos cipars");

            }
          


                

        }
        public static void CorectInput(string[] pos)
        {
            if (pos[step2] == "X" || pos[step1] == "O")

               //if ((pos[1] == "O" || pos[2] == "O" || pos[3] == "O" || pos[4] == "O" || pos[5] == "O" || pos[6] == "O" ||pos[7] == "O" || pos[8] == "O" || pos[9] == "O") || (pos[1] == "X" ||*/*/ pos[2] == "X" || pos[3] == "X" || pos[4] == "X" || pos[5] == "X" || pos[6] == "X" || pos[7] == "X" || pos[8] == "X" || pos[9] == "X"))
            {
                throw new CorectInput("Sis laucins ir aiznemts, ludzu izvelies citu");
            }
            

            //throw new CorectInput("Sis laucins ir aiznemts, ludzu izvelies citu");
        }

    }
}
