using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe1
{
    public class NotRightNumber : Exception

    {
        public NotRightNumber()
        {

        }
        public NotRightNumber(string message) : base(message)
        {

        }
        public NotRightNumber(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}

        

