using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Karan Patel Player Class

namespace Dicee_Game
{
    enum RollResult  //Enum which contains the results
    {
        Win,
        Lose,
        Jackpot
    }
    class Player
    {
       
        public string Name { get; set; }
        public int Score { get; set; }
        public List<RollResult> History { get;} //stores the roll

        public Player()
        {
            History = new List<RollResult>(); //creates/inits the list 
        }
    }
}
