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


            if (step < 0 && step > 10)
            {
                throw new NotRightNumber("neatbilstos cipars");

            }
          


                

        }
        
    }
}
