using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Karan Patel Dice class 
// This class rolls the dice and determines the amount of faces
namespace Dicee_Game
{
    class Dice
    {
        public int Face { get; private set; } 
        public int Max { get; set; }

        private readonly Random random; //creating random as readonly to store the random prop value

        public Dice(int max) //initilizing
        {
            Max = max; 
            random = new Random();
        }

        public void Roll()
        {
            Face = random.Next(1, Max); // New random # is created and assigned to face
        }
    }
}
