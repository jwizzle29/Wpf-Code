using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_V1._1
{
    [ComVisible(true)]
    public class GameException : Exception
    {
        public GameException()
        {

        }
        public GameException(string message)
        {

        }
    }
}
