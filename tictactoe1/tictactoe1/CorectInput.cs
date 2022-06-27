using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe1
{
    public class CorectInput : Exception
    {
        public CorectInput()
        {

        }
        public CorectInput(string message) : base(message)
        {

        }
        public CorectInput(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
