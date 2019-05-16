using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DartLeagueManager.Models
{
    public class CricketGame
    {
        public DateTime GameDate { get; set; }

        public CricketPlayer Player1 { get; set; }

        public int Player1Points { get; set; }

        public CricketPlayer Player2 { get; set; }

        public int Player2Points { get; set; }

        public int CurrentPlayer { get; set; }

        public bool Complete { get; set; }

        public void StartGame(CricketPlayer player1, CricketPlayer player2)
        {
            GameDate = DateTime.Now;
            Player1 = player1;
            Player2 = player2;
            CurrentPlayer = 1;
            
        }

        public void CancelGame()
        {

        }


        public CricketPlayer GetNextPlayer()
        {
            if (CurrentPlayer == 1) {
                CurrentPlayer = 2;
                return Player2;
            }

            CurrentPlayer = 1;
            return Player1;
        }

    }


    public class CricketPlayer
    {
        public string Name { get; set; }

        public int Points { get; set; }

        public int Twenties { get; set; }
        public int Nineteens { get; set; }
        public int Eighteens { get; set; }
        public int Seventeens { get; set; }
        public int Sixteens { get; set; }
        public int Fifteens { get; set; }
        public int Bulls { get; set; }

        public bool Win { get; set; }


    }

}
