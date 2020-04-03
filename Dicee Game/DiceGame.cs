using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicee_Game
{
    class DiceGame
    {
        public List<Player> Players { get; }
        public List<Dice> Dices { get; set; }
        public Player ActivePlayer { get; set; }
        public int TurnScore { get; private set; }
        public bool IsGameOver { get; }
    
        public DiceGame(int numOfDice)
        {
            Dices = new List<Dice>();
            Players = new List<Player>();
            
            for (int i = 0; i < numOfDice; i++)
            {
                Dice dice = new Dice(7); 
                Dices.Add(dice);
            }
        }

        public void AddPlayer(Player player) 
        {
            if (Players.Count > 2) 
            {
                throw new Exception("Game is in progress");

            }
            Players.Add(player); 
            
        }

        public void Start()
        {

            if (Players.Count < 2)
            {
                throw new Exception("Cant start the game (At least two players are needed)");

            }
            else 
            {
                while (IsGameOver) 
                {
                    for (int i = 0; i < Players.Count; i++) 
                    {
                        PlayTurn(Players[i]); 
                    }
                }



            }



        }
        public void RollDice()
        {
            foreach (var dice in Dices)
            {
                dice.Roll();
            }
        }

        public void ComputeResults(Player activePlayer)
        {


            for (int i = 1; i < Dices.Count; i++) 
            {

                TurnScore = 0;
                RollDice(); 
                //jackpot
                if (Dices[i - 1].Face == Dices[i].Face && Dices[i].Face == Dices[i].Max) 
                {
                    TurnScore = Dices[i].Face * 10;
                    UpdatePlayerStat(activePlayer, RollResult.Jackpot, TurnScore); 
                }
                //win = same number
                else if (Dices[i - 1].Face == Dices[i].Face && Dices[i].Face != Dices[i].Max) 
                {
                    TurnScore = Dices[i].Face * 5;
                    UpdatePlayerStat(activePlayer, RollResult.Win, TurnScore);
                }
                //loss
                else
                {
                    TurnScore = 0;
                    UpdatePlayerStat(activePlayer, RollResult.Lose, TurnScore); 
                }

            }



        }

        public void UpdatePlayerStat(Player currentPlayer, RollResult rollResults, int turnScore)
        {

            currentPlayer.Score += turnScore; 
            currentPlayer.History.Add(rollResults);


        }


        public void PlayTurn(Player player)
        {

            ActivePlayer = player;
            ComputeResults(ActivePlayer);



        }




        public void TheWinner()
        {
            //todo: output to program
         


        }

    }
}
